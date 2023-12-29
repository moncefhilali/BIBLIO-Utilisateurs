using Polly;
using Refit;
using Utilisateurs.Api.Health;
using Utilisateurs.Api.Interfaces;

namespace Utilisateurs.Api
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddDependecyInjectionApi(this IServiceCollection services)
        {
            // Health Check
            services.AddHealthChecks()
                .AddCheck<DatabaseHealthCheck>("Database")
                .AddCheck<MyJSONHealthCheck>("MyJSON API");

            // HttpClient
            services.AddHttpClient();

            // Polly
            var retryPolicy = Policy
                   .Handle<Exception>()
                   .RetryAsync(3);
            services.AddSingleton(retryPolicy);

            // Refit
            services.AddRefitClient<IMyJSON>()
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri("https://my-json-server.typicode.com/moncefhilali/MyAPI/");
                });

            return services;
        }
    }
}
