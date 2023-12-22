using Utilisateurs.Domain.Entities;

namespace Utilisateurs.Application.ViewModels
{
    public class UtilisateurRoleViewModel
    {
        public int Id { get; set; }
        public int? IdUtilisateur { get; set; }
        public int? IdRole { get; set; }
        public virtual Role IdRoleNavigation { get; set; }
        public virtual Utilisateur IdUtilisateurNavigation { get; set; }
    }
}
