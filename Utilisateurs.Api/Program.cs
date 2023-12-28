using Utilisateurs.Infrastructure;
using Utilisateurs.Application;
using Refit;
using Utilisateurs.Api.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDependecyInjectionInfrastructure();
builder.Services.AddDependecyInjectionApplication();

builder.Services.AddHttpClient();
builder.Services.AddRefitClient<IMyJSON>()
    .ConfigureHttpClient(c =>
    {
        c.BaseAddress = new Uri("https://my-json-server.typicode.com/moncefhilali/MyAPI/");
    });


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
