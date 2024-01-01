using Microsoft.EntityFrameworkCore;
using Utilisateurs.Domain.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Utilisateurs.Infrastructure
{
    public partial class DBC : DbContext
    {
        public DBC()
        {
        }

        public DBC(DbContextOptions<DBC> options)
            : base(options)
        {
        }

        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
        public virtual DbSet<UtilisateurRole> UtilisateurRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-3SA4E25\\SQLEXPRESS;Initial Catalog=JIT_BIBLIO;Persist Security Info=True;User ID=sa;Password=1234");
            }
        }
    }
}
