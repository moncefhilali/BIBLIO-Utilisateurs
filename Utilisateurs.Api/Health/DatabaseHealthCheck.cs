using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Utilisateurs.Infrastructure;

namespace Utilisateurs.Api.Health
{
    public class DatabaseHealthCheck : IHealthCheck
    {
        private readonly DBC _dbContext;
        public DatabaseHealthCheck(DBC dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                await _dbContext.Database.ExecuteSqlRawAsync("SELECT 1", cancellationToken);
                return HealthCheckResult.Healthy("Database is responding.");
            }
            catch (Exception ex)
            {
                return HealthCheckResult.Unhealthy("An error occurred while checking the database.", ex);
            }
        }
    }
}
