using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Utilisateurs.Domain.Entities
{
    public partial class Role
    {
        public Role()
        {
            UtilisateurRole = new HashSet<UtilisateurRole>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Nom { get; set; }

        [InverseProperty("IdRoleNavigation")]
        public virtual ICollection<UtilisateurRole> UtilisateurRole { get; set; }
    }
}
