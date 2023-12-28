using MediatR;
using Utilisateurs.Application.Roles.ViewModel;

namespace Utilisateurs.Application.Roles.Queries
{
    public class GetAllRoleQuery : IRequest<List<RoleViewModel>>
    {

    }
}
