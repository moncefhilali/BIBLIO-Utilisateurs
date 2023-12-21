using MediatR;
using Utilisateurs.Domain.Entities;

namespace Utilisateurs.Application.Queries
{
    public class GetAllUtilisateurQuery : IRequest<List<Utilisateur>>
    {

    }
}
