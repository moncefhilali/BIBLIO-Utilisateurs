using Microsoft.AspNetCore.Mvc;

namespace Utilisateurs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
