using MediatR;
using Utilisateurs.Application.Utilisateurs.ViewModel;

namespace Utilisateurs.Application.Utilisateurs.Queries
{
    public class GetAllUtilisateurQuery : IRequest<List<UtilisateurViewModel>>
    {

    }
}
