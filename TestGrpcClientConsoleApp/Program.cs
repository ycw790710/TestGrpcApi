using Grpc.Net.Client;
using System.Diagnostics;
using TestGrpcApi;

namespace TestGrpcClientConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:52345/");
            await channel.ConnectAsync();
            var client = new Greeter.GreeterClient(channel);
            Console.WriteLine($"{channel.State}");

            int count = 0;
            int targetMilliseconds = 3000;
            Stopwatch sw = new();
            sw.Start();
            while (sw.ElapsedMilliseconds <= targetMilliseconds)
            {
                var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
                var msg = reply.Message;
                Interlocked.Increment(ref count);
            }            
            sw.Stop();
            Console.WriteLine($"ElapsedMilliseconds:{sw.ElapsedMilliseconds}");
            Console.WriteLine($"count:{count}");
            Console.WriteLine($"{channel.State}");

            Console.ReadLine();
        }
    }
}