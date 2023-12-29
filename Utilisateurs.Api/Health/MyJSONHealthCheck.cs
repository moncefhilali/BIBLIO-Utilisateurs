using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Utilisateurs.Api.Health
{
    public class MyJSONHealthCheck : IHealthCheck
    {
        private readonly HttpClient _httpClient;
        public MyJSONHealthCheck(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                await _httpClient.GetAsync("https://my-json-server.typicode.com/moncefhilali/MyAPI/db");
                return HealthCheckResult.Healthy("Successfully connected to the MyJSON API");
            }
            catch (Exception ex)
            {
                return HealthCheckResult.Unhealthy("Failed to connect to the MyJSON API.", ex);
            }
        }
    }
}
