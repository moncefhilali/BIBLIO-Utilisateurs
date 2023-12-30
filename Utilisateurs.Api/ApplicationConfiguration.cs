using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.RateLimiting;
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
            // API Versioning
            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                options.ReportApiVersions = true;
                options.ApiVersionReader = ApiVersionReader.Combine(new HeaderApiVersionReader("x-version"));
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });

            // Rate Limiter
            services.AddRateLimiter(options =>
            {
                options.AddFixedWindowLimiter("FixedWindowPolicy", opt =>
                {
                    opt.Window = TimeSpan.FromSeconds(10);
                    opt.PermitLimit = 1;
                    opt.QueueLimit = 1;
                    opt.QueueProcessingOrder = System.Threading.RateLimiting.QueueProcessingOrder.OldestFirst;
                }).RejectionStatusCode = 429;
            });

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
