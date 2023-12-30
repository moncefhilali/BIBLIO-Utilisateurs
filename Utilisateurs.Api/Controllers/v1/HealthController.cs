using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace Utilisateurs.Api.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [EnableRateLimiting("FixedWindowPolicy")]
    public class HealthController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        public HealthController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> CheckHealth()
        {
            var result = await _httpClient.GetFromJsonAsync<object?>("https://localhost:7256/_health");
            return Ok(result);
        }
    }
}
