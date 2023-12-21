using Utilisateurs.Domain.Entities;
using Utilisateurs.Domain.Interfaces;

namespace Utilisateurs.Infrastructure.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(DBC dbc) : base(dbc) { }

        // Additional Methods
    }
}
