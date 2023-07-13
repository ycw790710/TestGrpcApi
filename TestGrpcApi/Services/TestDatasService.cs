using Grpc.Core;
using TestDatasNameSpace;

namespace TestGrpcApi.Services
{
    public class TestDatasService : TestDatasSer.TestDatasSerBase
    {

        public override Task<TestDataCommandReply> Command(TestDataCommandRequest request, ServerCallContext context)
        {
            var testDataCommandReply = new TestDataCommandReply
            {
                Message = "",
            };
            testDataCommandReply.Detail[0] = "123";
            testDataCommandReply.G["g"] = 123;
            return Task.FromResult(testDataCommandReply);
        }
    }
}
