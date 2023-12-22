using AutoMapper;
using MediatR;
using Utilisateurs.Application.Queries;
using Utilisateurs.Domain.DTOs.RoleDTOs;
using Utilisateurs.Domain.Interfaces;

namespace Utilisateurs.Application.Handlers
{
    public class GetAllRoleQueryHandler : IRequestHandler<GetAllRoleQuery, List<RoleDTO>>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        public GetAllRoleQueryHandler(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<List<RoleDTO>> Handle(GetAllRoleQuery request, CancellationToken cancellationToken)
        {
            var roles = await _roleRepository.GetAllAsync();
            return _mapper.Map<List<RoleDTO>>(roles);
        }
    }
}
