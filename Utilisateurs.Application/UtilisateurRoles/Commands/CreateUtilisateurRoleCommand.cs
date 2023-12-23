using MediatR;
using Utilisateurs.Application.ViewModels;

namespace Utilisateurs.Application.UtilisateurRoles.Commands
{
    public class CreateUtilisateurRoleCommand : IRequest<UtilisateurRoleViewModel>
    {
        public int? IdUtilisateur { get; set; }
        public int? IdRole { get; set; }
    }
}
