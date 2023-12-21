using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Utilisateurs.Domain.Entities
{
    [Table("Utilisateur_Role")]
    public partial class UtilisateurRole
    {
        [Key]
        public int Id { get; set; }
        public int? IdUtilisateur { get; set; }
        public int? IdRole { get; set; }

        [ForeignKey(nameof(IdRole))]
        [InverseProperty(nameof(Role.UtilisateurRole))]
        public virtual Role IdRoleNavigation { get; set; }
        [ForeignKey(nameof(IdUtilisateur))]
        [InverseProperty(nameof(Utilisateur.UtilisateurRole))]
        public virtual Utilisateur IdUtilisateurNavigation { get; set; }
    }
}
