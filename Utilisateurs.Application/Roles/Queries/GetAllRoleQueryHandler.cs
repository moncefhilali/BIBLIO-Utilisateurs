using AutoMapper;
using MediatR;
using Utilisateurs.Domain.Interfaces;
using Utilisateurs.Application.Roles.Queries;
using Utilisateurs.Application.ViewModels;

namespace Utilisateurs.Application.Roles.Queries
{
    public class GetAllRoleQueryHandler : IRequestHandler<GetAllRoleQuery, List<RoleViewModel>>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        public GetAllRoleQueryHandler(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<List<RoleViewModel>> Handle(GetAllRoleQuery request, CancellationToken cancellationToken)
        {
            var roles = await _roleRepository.GetAllAsync();
            return _mapper.Map<List<RoleViewModel>>(roles);
        }
    }
}
