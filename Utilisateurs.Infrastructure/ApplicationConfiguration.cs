using Microsoft.Extensions.DependencyInjection;
using Utilisateurs.Domain.Interfaces;
using Utilisateurs.Infrastructure.Repositories;

namespace Utilisateurs.Infrastructure
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddDependecyInjectionInfrastructure(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUtilisateurRepository, UtilisateurRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUtilisateurRoleRepository, UtilisateurRoleRepository>();

            // DbContext
            services.AddScoped<DBC>();

            return services;
        }
    }
}
