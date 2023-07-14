using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using TestGrpcInterface;

namespace TestGrpcApi.Services
{
    [Authorize]
    public class Test2Service : TestGrpc2.TestGrpc2Base
    {
        private readonly ILogger<Test2Service> _logger;
        public Test2Service(ILogger<Test2Service> logger)
        {
            _logger = logger;
        }

        public override Task<TestHelloReply2> SayHello(TestHelloRequest2 request, ServerCallContext context)
        {
            return base.SayHello(request, context);
        }
    }
}
