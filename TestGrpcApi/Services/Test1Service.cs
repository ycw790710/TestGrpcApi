using Grpc.Core;
using TestGrpcInterface;

namespace TestGrpcApi.Services
{
    public class Test1Service : TestGrpc.TestGrpcBase
    {
        private readonly ILogger<Test1Service> _logger;
        public Test1Service(ILogger<Test1Service> logger)
        {
            _logger = logger;
        }

        public override Task<TestHelloReply> SayHello(TestHelloRequest request, ServerCallContext context)
        {
            return base.SayHello(request, context);
        }
    }
}
