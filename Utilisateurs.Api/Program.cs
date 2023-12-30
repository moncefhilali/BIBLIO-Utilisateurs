using Utilisateurs.Infrastructure;
using Utilisateurs.Application;
using Utilisateurs.Api;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using HealthChecks.UI.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDependecyInjectionInfrastructure();
builder.Services.AddDependecyInjectionApplication();
builder.Services.AddDependecyInjectionApi();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Map Health Checks
app.MapHealthChecks("/_health", new HealthCheckOptions
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

// Rate Limiter
app.UseRateLimiter();

app.UseAuthorization();

app.MapControllers();

app.Run();
