using MediatR;
using Utilisateurs.Domain.Entities;
using Utilisateurs.Domain.DTOs.UtilisateurDTOs;

namespace Utilisateurs.Application.Commands
{
    public class CreateUtilisateurCommand : IRequest<UtilisateurDTO>
    {
        public Utilisateur NewUtilisateur { get; set; }

    }
}
