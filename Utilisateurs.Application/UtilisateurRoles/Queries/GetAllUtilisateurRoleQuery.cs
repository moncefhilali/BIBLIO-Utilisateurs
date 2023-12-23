using MediatR;
using Utilisateurs.Application.ViewModels;

namespace Utilisateurs.Application.UtilisateurRoles.Queries
{
    public class GetAllUtilisateurRoleQuery : IRequest<List<UtilisateurRoleViewModel>>
    {

    }
}
