using MediatR;
using Utilisateurs.Application.ViewModels;

namespace Utilisateurs.Application.Roles.Commands
{
    public class CreateRoleCommand : IRequest<RoleViewModel>
    {
        public string Nom { get; set; }
    }
}
