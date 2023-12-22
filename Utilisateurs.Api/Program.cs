using MediatR;
using Utilisateurs.Application.Utilisateurs.Queries;
using Utilisateurs.Application.Roles.Queries;
using Utilisateurs.Domain.Interfaces;
using Utilisateurs.Application.Mapper;
using Utilisateurs.Infrastructure;
using Utilisateurs.Infrastructure.Repositories;
using Utilisateurs.Application.Roles.Commands;
using Utilisateurs.Application.Utilisateurs.Commands;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(typeof(GetAllUtilisateurQuery));
builder.Services.AddMediatR(typeof(CreateUtilisateurCommand));
builder.Services.AddMediatR(typeof(GetAllRoleQuery));
builder.Services.AddMediatR(typeof(CreateRoleCommand));

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<DBC>();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUtilisateurRepository, UtilisateurRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IUtilisateurRoleRepository, UtilisateurRoleRepository>();


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
