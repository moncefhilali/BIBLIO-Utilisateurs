using MediatR;
using Utilisateurs.Domain.DTOs.RoleDTOs;

namespace Utilisateurs.Application.Queries
{
    public class GetAllRoleQuery : IRequest<List<RoleDTO>>
    {

    }
}
