using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Utilisateurs.Application.Mapper;
using Utilisateurs.Application.Roles.Commands;
using Utilisateurs.Application.Roles.Queries;
using Utilisateurs.Application.UtilisateurRoles.Commands;
using Utilisateurs.Application.UtilisateurRoles.Queries;
using Utilisateurs.Application.Utilisateurs.Commands;
using Utilisateurs.Application.Utilisateurs.Queries;

namespace Utilisateurs.Application
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddDependecyInjectionApplication(this IServiceCollection services)
        {
            // MediatR
            services.AddMediatR(typeof(GetAllUtilisateurQuery));
            services.AddMediatR(typeof(CreateUtilisateurCommand));
            services.AddMediatR(typeof(GetAllRoleQuery));
            services.AddMediatR(typeof(CreateRoleCommand));
            services.AddMediatR(typeof(GetAllUtilisateurRoleQuery));
            services.AddMediatR(typeof(CreateUtilisateurRoleCommand));

            // Mapper
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
