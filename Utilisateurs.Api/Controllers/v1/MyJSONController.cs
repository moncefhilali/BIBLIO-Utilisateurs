using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using Polly.Retry;
using Utilisateurs.Api.Interfaces;

namespace Utilisateurs.Api.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    public class MyJSONController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly IMyJSON _myJSON;
        private readonly AsyncRetryPolicy _retryPolicy;
        public MyJSONController(HttpClient httpClient, IMyJSON myJSON, AsyncRetryPolicy retryPolicy)
        {
            _httpClient = httpClient;
            _myJSON = myJSON;
            _retryPolicy = retryPolicy;
        }

        [HttpGet("HttpClient")]
        public async Task<IActionResult> GetHttpClient()
        {
            var url = "https://my-json-server.typicode.com/moncefhilali/MyAPI/";
            var result = await _httpClient.GetFromJsonAsync<object?>(url + "db");
            return Ok(result);
        }

        [HttpGet("Flurl")]
        public async Task<IActionResult> GetFlurl()
        {
            var url = "https://my-json-server.typicode.com/moncefhilali/MyAPI";
            var result = await url.AppendPathSegment("db").GetJsonAsync<object?>();
            return Ok(result);
        }

        [HttpGet("Refit")]
        public async Task<IActionResult> GetRefit()
        {
            var result = await _myJSON.GetMyJSON();
            return Ok(result);
        }
    }
}
