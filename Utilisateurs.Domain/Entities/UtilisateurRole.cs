namespace Utilisateurs.Domain.Entities
{
    public class UtilisateurRole
    {
        public int Id { get; set; }
        public int? IdUtilisateur { get; set; }
        public int? IdRole { get; set; }
    }
}
