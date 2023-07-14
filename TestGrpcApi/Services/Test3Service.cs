using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using TestNameSpace;

namespace TestGrpcApi.Services
{
    [Authorize]
    public class Test3Service : TestService.TestServiceBase
    {
        private readonly ILogger<Test3Service> _logger;
        public Test3Service(ILogger<Test3Service> logger)
        {
            _logger = logger;
        }

        public override Task<TestReply> TestMethod(TestRequest request, ServerCallContext context)
        {
            var testReply = new TestReply();
            testReply.Name = "name";
            testReply.Items.Add(new TestItem() { Name = "name", Item = new TestItem2() });
            return Task.FromResult(testReply);
        }
    }
}
