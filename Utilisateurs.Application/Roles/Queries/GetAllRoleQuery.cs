using MediatR;
using Utilisateurs.Application.ViewModels;

namespace Utilisateurs.Application.Roles.Queries
{
    public class GetAllRoleQuery : IRequest<List<RoleViewModel>>
    {

    }
}
