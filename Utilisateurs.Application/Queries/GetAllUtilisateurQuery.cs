using MediatR;
using Utilisateurs.Domain.DTOs.UtilisateurDTOs;
using Utilisateurs.Domain.Entities;

namespace Utilisateurs.Application.Queries
{
    public class GetAllUtilisateurQuery : IRequest<List<UtilisateurDTO>>
    {

    }
}
