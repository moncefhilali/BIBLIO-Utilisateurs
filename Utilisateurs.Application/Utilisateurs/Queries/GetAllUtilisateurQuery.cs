using MediatR;
using Utilisateurs.Application.ViewModels;

namespace Utilisateurs.Application.Utilisateurs.Queries
{
    public class GetAllUtilisateurQuery : IRequest<List<UtilisateurViewModel>>
    {

    }
}
