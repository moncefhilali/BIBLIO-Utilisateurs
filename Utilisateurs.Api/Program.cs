using Utilisateurs.Infrastructure;
using Utilisateurs.Application;
using Refit;
using Utilisateurs.Api.Interfaces;
using Polly;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDependecyInjectionInfrastructure();
builder.Services.AddDependecyInjectionApplication();

// HttpClient
builder.Services.AddHttpClient();

// Refit
builder.Services.AddRefitClient<IMyJSON>()
    .ConfigureHttpClient(c =>
    {
        c.BaseAddress = new Uri("https://my-json-server.typicode.com/moncefhilali/MyAPI/");
    });

// Polly
var retryPolicy = Policy
       .Handle<Exception>()
       .RetryAsync(3);
builder.Services.AddSingleton(retryPolicy);


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

app.UseAuthorization();

app.MapControllers();

app.Run();
