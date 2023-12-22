using Utilisateurs.Domain.Entities;
using Utilisateurs.Domain.Interfaces;

namespace Utilisateurs.Infrastructure.Repositories
{
    public class UtilisateurRepository : GenericRepository<Utilisateur>, IUtilisateurRepository
    {
        public UtilisateurRepository(DBC dbc) : base(dbc) { }

        // Additional Methods
    }
}
