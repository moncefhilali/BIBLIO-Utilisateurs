using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;

namespace Utilisateurs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyJSONController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        public MyJSONController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("HttpClient")]
        public async Task<IActionResult> GetHttpClient()
        {
            var url = "https://my-json-server.typicode.com/moncefhilali/MyAPI/db";
            var result = await _httpClient.GetFromJsonAsync<object?>(url);
            return Ok(result);
        }

        [HttpGet("Flurl")]
        public async Task<IActionResult> GetFlurl()
        {
            var url = "https://my-json-server.typicode.com/moncefhilali/MyAPI";
            var result = await url
                .AppendPathSegment("db")
                .WithHeader("Accept", "application/json")
                .GetJsonAsync<object?>();
            return Ok(result);
        }
    }
}
