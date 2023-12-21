using Utilisateurs.Domain.Entities;

namespace Utilisateurs.Domain.DTOs.RoleDTOs
{
    public class RoleDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public virtual ICollection<UtilisateurRole> UtilisateurRole { get; set; }
    }
}
