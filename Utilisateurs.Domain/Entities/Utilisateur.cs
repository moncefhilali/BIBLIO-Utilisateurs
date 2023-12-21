using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Utilisateurs.Domain.Entities
{
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            UtilisateurRole = new HashSet<UtilisateurRole>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Nom { get; set; }
        [StringLength(250)]
        public string Email { get; set; }
        [StringLength(250)]
        public string Ecole { get; set; }
        [StringLength(250)]
        public string Ville { get; set; }
        [StringLength(250)]
        public string Rue { get; set; }
        [StringLength(250)]
        public string Quartier { get; set; }
        public bool? JobInTech { get; set; }

        [InverseProperty("IdUtilisateurNavigation")]
        public virtual ICollection<UtilisateurRole> UtilisateurRole { get; set; }
    }
}
