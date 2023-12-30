using Utilisateurs.Domain.Entities;

namespace Utilisateurs.Application.UtilisateurRoles.ViewModel
{
    public class UtilisateurRoleViewModel
    {
        public int Id { get; set; }
        public int? IdUtilisateur { get; set; }
        public int? IdRole { get; set; }
    }
}
