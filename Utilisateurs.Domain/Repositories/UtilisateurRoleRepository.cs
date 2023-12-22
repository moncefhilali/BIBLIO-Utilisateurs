﻿using Utilisateurs.Domain.Entities;
using Utilisateurs.Infrastructure.Interfaces;

namespace Utilisateurs.Infrastructure.Repositories
{
    public class UtilisateurRoleRepository : GenericRepository<UtilisateurRole>, IUtilisateurRoleRepository
    {
        public UtilisateurRoleRepository(DBC dbc) : base(dbc) { }

        // Additional Methods

    }
}
