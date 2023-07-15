using Grpc.Core;
using Grpc.Net.Client;
using System.Diagnostics;
using TestGrpcApi;
using TestNameSpace;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Linq;
using System.Net.Mime;
using System.Net;
using System.Security.Authentication;

namespace TestGrpcClientConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var uriAddress = "https://localhost:52346/";

            var token = GetToken(GetSecretKey());
            var credentials = CallCredentials.FromInterceptor(async (context, metadata) =>
            {
                metadata.Add("Authorization", $"Bearer {token}");
            });

            var handler = new SocketsHttpHandler
            {
                PooledConnectionIdleTimeout = Timeout.InfiniteTimeSpan,
                KeepAlivePingDelay = TimeSpan.FromSeconds(30),
                KeepAlivePingTimeout = TimeSpan.FromSeconds(15),
                EnableMultipleHttp2Connections = true,
            };
            handler.SslOptions.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls13;

            using GrpcChannel channel = GrpcChannel.ForAddress(uriAddress, new GrpcChannelOptions
            {
                Credentials = ChannelCredentials.Create(new SslCredentials(), credentials),
                HttpHandler = handler
            });
            await channel.ConnectAsync();
            Console.WriteLine($"channel.State: {channel.State}");
            Console.WriteLine($"channel.Target: {channel.Target}");
            Console.WriteLine();

            await TestGrpcIteration(channel);
            await TestGrpcIteration(channel);
            await TestControllerIteration();
            await TestControllerIteration();
            TestGrpcTasks(channel);
            TestGrpcTasks(channel);
            Console.Read();
        }

        static byte[] GetSecretKey()
        {
            // eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoidGVzdEFwaUNsaWVudCIsImV4cCI6MTY4OTQxNzY0NywiaXNzIjoiVGVzdEdycGMiLCJhdWQiOiJUZXN0R3JwYyJ9._P4ZI4Gvvtj3Nge3XC8wlHjT4f-D-MR_BRN1_z4xgLAE5GWxb59gbNCYxRMxokF3IRz6naSvn6bWfhQFs5VHQg
            var bytes = Encoding.UTF8.GetBytes("askjdhf98asdf9h25khns;lzdfh98sddfbu;12kjaiodhjgo;aihew4t-89q34nop;asdok;fg");
            Array.Resize(ref bytes, 64);
            return bytes;
        }

        static string GetToken(byte[] secretKey)
        {
            var signingKey = new SymmetricSecurityKey(secretKey);

            var claims = CreateClaims();

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: "TestGrpc",
                audience: "TestGrpc",
                claims: claims,
                expires: DateTime.Now.AddMinutes(1),
                signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha512)
            );

            return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        }

        static IEnumerable<Claim> CreateClaims()
        {
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, "testApiClient"),
        };
            return claims;
        }


        static async Task TestGrpcIteration(GrpcChannel channel)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"---{nameof(TestGrpcIteration)}---");
            Console.ResetColor();

            var client = new Greeter.GreeterClient(channel);

            Stopwatch sw = new();
            int processedCount = 0;
            int targetMilliseconds = 3000;

            sw.Start();
            while (sw.ElapsedMilliseconds <= targetMilliseconds)
            {
                var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
                var msg = reply.Message;
                Interlocked.Increment(ref processedCount);
                Console.Write($"\rcount: {processedCount}");
            }
            Console.WriteLine();
            sw.Stop();

            Console.WriteLine($"Elapsed Milliseconds: {sw.ElapsedMilliseconds}");
            Console.WriteLine($"processed count: {processedCount}");
            Console.WriteLine();
        }

        static async Task TestControllerIteration()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"---{nameof(TestControllerIteration)}---");
            Console.ResetColor();

            var handler = new HttpClientHandler()
            {
                SslProtocols = SslProtocols.Tls13
            };
            var httpClient = new HttpClient(handler) { DefaultRequestVersion = new Version(2, 0) };
            httpClient.BaseAddress = new Uri("https://localhost:52345/");            

            var jwtToken = GetToken(GetSecretKey());
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);

            Stopwatch sw = new();
            int processedCount = 0;
            int targetMilliseconds = 3000;
            int dataCount = 1;

            sw.Start();
            while (sw.ElapsedMilliseconds <= targetMilliseconds)
            {
                var testDataRequest = new TestDataRequest { message = $"{dataCount}" };
                var requestData = new StringContent(JsonSerializer.Serialize(testDataRequest), Encoding.UTF8, MediaTypeNames.Application.Json);
                var response = await httpClient.PostAsync("api/Test/GetTestData", requestData);
                response.EnsureSuccessStatusCode();
                var responseContent = await response.Content.ReadAsStringAsync();
                var testDataDto = JsonSerializer.Deserialize<TestDataDto>(responseContent);
                if (!testDataDto.message.Contains(dataCount.ToString()))
                    break;

                dataCount++;
                Interlocked.Increment(ref processedCount);
                Console.Write($"\rcount: {processedCount}");
            }
            Console.WriteLine();
            sw.Stop();

            Console.WriteLine($"Elapsed Milliseconds: {sw.ElapsedMilliseconds}");
            Console.WriteLine($"processed count: {processedCount}");
            Console.WriteLine();
        }

        static void TestGrpcTasks(GrpcChannel channel)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"---{nameof(TestGrpcTasks)}---");
            Console.ResetColor();

            int record_successCount = 0;
            int record_failCount = 0;
            Stopwatch sw = new();
            int processedCount = 0;
            int targetMilliseconds = 3000;
            ManualResetEventSlim manualResetEventSlim = new(false);
            int taskCount = 100;
            ThreadPool.SetMinThreads(101, 3);// here for test

            int readyCount = 0;
            int finishedCount = 0;

            object _lockCreateClientTicks = new();
            long createClientTicks = 0;

            for (int i = 0; i < taskCount; i++)
            {
                var processId = i;
                Task.Run(async () =>
                {
                    var dataId = 0;

                    Stopwatch swClient = new();
                    Interlocked.Increment(ref readyCount);
                    manualResetEventSlim.Wait();
                    while (sw.ElapsedMilliseconds <= targetMilliseconds)
                    {
                        swClient.Start();
                        var client = new Greeter.GreeterClient(channel);
                        swClient.Stop();

                        var id = $"{processId},{dataId}";
                        var reply = await client.SayHelloAsync(new HelloRequest { Name = $"Msg,{id}" });
                        var msg = reply.Message;
                        if (!msg.Contains(id))
                        {
                            Interlocked.Increment(ref record_failCount);
                            break;
                        }
                        Interlocked.Increment(ref record_successCount);

                        Interlocked.Increment(ref processedCount);
                        dataId++;
                    }
                    lock (_lockCreateClientTicks)
                        createClientTicks += swClient.ElapsedTicks;
                    Interlocked.Increment(ref finishedCount);
                });
            }

            Console.WriteLine($"tasks count: {taskCount}");
            while (readyCount < taskCount)
            {
                var pre = readyCount;
                SpinWait.SpinUntil(() => pre != readyCount || readyCount == taskCount);
                Console.Write($"\r準備task進度: {readyCount}/{taskCount}");
            }
            Console.WriteLine();

            sw.Start();
            manualResetEventSlim.Set();
            while (finishedCount < taskCount)
            {
                var pre = finishedCount;
                SpinWait.SpinUntil(() => pre != finishedCount || finishedCount == taskCount);
                Console.Write($"\r完成task進度: {finishedCount}/{taskCount}");
            }
            Console.WriteLine();
            sw.Stop();

            Console.WriteLine($"create client milliseconds: {createClientTicks * 1000 / Stopwatch.Frequency}");
            Console.WriteLine($"Elapsed Milliseconds: {sw.ElapsedMilliseconds}");
            Console.WriteLine($"success count: {record_successCount}");
            Console.WriteLine($"fail count: {record_failCount}");
            Console.WriteLine($"processed count: {processedCount}");
            Console.WriteLine();

        }
    }
}