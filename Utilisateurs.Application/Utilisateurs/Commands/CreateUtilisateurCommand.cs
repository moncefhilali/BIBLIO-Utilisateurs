using MediatR;
using Utilisateurs.Application.ViewModels;

namespace Utilisateurs.Application.Utilisateurs.Commands
{
    public class CreateUtilisateurCommand : IRequest<UtilisateurViewModel>
    {
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Ecole { get; set; }
        public string Ville { get; set; }
        public string Rue { get; set; }
        public string Quartier { get; set; }
        public bool? JobInTech { get; set; }

    }
}
