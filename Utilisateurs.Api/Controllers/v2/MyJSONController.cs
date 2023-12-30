using Microsoft.AspNetCore.Mvc;
using Polly.Retry;
using Utilisateurs.Api.Interfaces;

namespace Utilisateurs.Api.Controllers.v2
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class MyJSONController : ControllerBase
    {
        private readonly IMyJSON _myJSON;
        private readonly AsyncRetryPolicy _retryPolicy;
        public MyJSONController(IMyJSON myJSON, AsyncRetryPolicy retryPolicy)
        {
            _myJSON = myJSON;
            _retryPolicy = retryPolicy;
        }

        [HttpGet("Refit")]
        public async Task<IActionResult> GetRefit()
        {
            var result = await _retryPolicy.ExecuteAsync(async () => await _myJSON.GetMyJSON());
            return Ok(result);
        }
    }
}
