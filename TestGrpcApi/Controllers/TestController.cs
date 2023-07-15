using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestGrpcApi.Dtos;

namespace TestGrpcApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class TestController : ControllerBase
    {

        public TestController()
        {

        }

        [HttpPost]
        public async Task<ActionResult<TestDataDto>> GetTestData([FromBody] TestDataRequest testDataRequest)
        {
            var testDataDto = new TestDataDto() { message = "received: " + testDataRequest.message };
            return Ok(testDataDto);
        }
    }
}
