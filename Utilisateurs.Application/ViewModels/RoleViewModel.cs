using Utilisateurs.Domain.Entities;

namespace Utilisateurs.Application.ViewModels
{
    public class RoleViewModel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public virtual ICollection<UtilisateurRole> UtilisateurRole { get; set; }
    }
}
