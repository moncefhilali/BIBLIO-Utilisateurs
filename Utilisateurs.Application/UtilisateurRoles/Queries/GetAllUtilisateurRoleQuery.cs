using MediatR;
using Utilisateurs.Application.UtilisateurRoles.ViewModel;

namespace Utilisateurs.Application.UtilisateurRoles.Queries
{
    public class GetAllUtilisateurRoleQuery : IRequest<List<UtilisateurRoleViewModel>>
    {

    }
}
