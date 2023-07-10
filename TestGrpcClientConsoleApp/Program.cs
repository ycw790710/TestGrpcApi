using Grpc.Net.Client;
using System.Diagnostics;
using TestGrpcApi;

namespace TestGrpcClientConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var uriAddress = "https://localhost:52345/";

            using GrpcChannel channel = GrpcChannel.ForAddress(uriAddress);
            await channel.ConnectAsync();
            Console.WriteLine($"channel.State:{channel.State}");

            await TestIteration(channel);
            TestTasks(channel);

            Console.WriteLine($"channel.State:{channel.State}");
            Console.ReadLine();
        }

        static async Task TestIteration(GrpcChannel channel)
        {
            Console.WriteLine($"---{nameof(TestIteration)}---");

            var client = new Greeter.GreeterClient(channel);

            Stopwatch sw = new();
            int count = 0;
            int targetMilliseconds = 3000;

            sw.Start();
            while (sw.ElapsedMilliseconds <= targetMilliseconds)
            {
                var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
                var msg = reply.Message;
                Interlocked.Increment(ref count);
                Console.Write($"\rcount：{count}");
            }
            Console.WriteLine();
            sw.Stop();

            Console.WriteLine($"Elapsed Milliseconds:{sw.ElapsedMilliseconds}");
            Console.WriteLine($"count:{count}");
            Console.WriteLine();
        }

        static void TestTasks(GrpcChannel channel)
        {
            Console.WriteLine($"---{nameof(TestTasks)}---");

            Stopwatch sw = new();
            int count = 0;
            int targetMilliseconds = 3000;
            ManualResetEventSlim manualResetEventSlim = new(false);
            int taskCount = 40;
            int readyCount = 0;
            int finishedCount = 0;

            object _lockCreateClientMilliseconds = new();
            long createClientTicks = 0;

            for (int i = 0; i < taskCount; i++)
            {
                var a = i;
                Task.Run(async () =>
                {
                    var b = 0;

                    Stopwatch swClient = new();
                    swClient.Start();
                    var client = new Greeter.GreeterClient(channel);
                    swClient.Stop();
                    lock(_lockCreateClientMilliseconds)
                        createClientTicks += swClient.ElapsedTicks;

                    Interlocked.Increment(ref readyCount);
                    manualResetEventSlim.Wait();
                    while (sw.ElapsedMilliseconds <= targetMilliseconds)
                    {
                        var id = $"{a},{b}";
                        var reply = await client.SayHelloAsync(new HelloRequest { Name = $"Msg,{id}" });
                        var msg = reply.Message;
                        if (!msg.Contains(id))
                            break;
                        Interlocked.Increment(ref count);
                        b++;
                    }
                    Interlocked.Increment(ref finishedCount);
                });
            }

            Console.WriteLine($"tasks count:{taskCount}");
            while (readyCount < taskCount)
            {
                var pre = readyCount;
                SpinWait.SpinUntil(() => pre != readyCount || readyCount == taskCount);
                Console.Write($"\r準備task進度：{readyCount}/{taskCount}");
            }
            Console.WriteLine();
            Console.WriteLine($"create client ticks:{createClientTicks}");

            sw.Start();
            manualResetEventSlim.Set();
            while (finishedCount < taskCount)
            {
                var pre = finishedCount;
                SpinWait.SpinUntil(() => pre != finishedCount || finishedCount == taskCount);
                Console.Write($"\r完成task進度：{finishedCount}/{taskCount}");
            }
            Console.WriteLine();
            sw.Stop();

            Console.WriteLine($"Elapsed Milliseconds:{sw.ElapsedMilliseconds}");
            Console.WriteLine($"count:{count}");
            Console.WriteLine();
        }
    }
}