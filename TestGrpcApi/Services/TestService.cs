using Grpc.Core;
using TestGrpcInterface;

namespace TestGrpcApi.Services
{
    public class TestService : TestGrpc.TestGrpcBase
    {
        private readonly ILogger<TestService> _logger;
        public TestService(ILogger<TestService> logger)
        {
            _logger = logger;
        }

        public override Task<TestHelloReply> SayHello(TestHelloRequest request, ServerCallContext context)
        {
            return base.SayHello(request, context);
        }
    }
}
