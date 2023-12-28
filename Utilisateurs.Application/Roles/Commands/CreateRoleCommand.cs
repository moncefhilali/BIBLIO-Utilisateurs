using MediatR;
using Utilisateurs.Application.Roles.ViewModel;

namespace Utilisateurs.Application.Roles.Commands
{
    public class CreateRoleCommand : IRequest<RoleViewModel>
    {
        public string Nom { get; set; }
    }
}
