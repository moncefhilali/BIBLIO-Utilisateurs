using AutoMapper;
using MediatR;
using Utilisateurs.Application.Roles.Commands;
using Utilisateurs.Domain.Entities;
using Utilisateurs..Interfaces;
using Utilisateurs.Application.ViewModels;

namespace Utilisateurs.Application.Roles.Commands
{
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, RoleViewModel>
    {
        private readonly IRoleRepository _repository;
        private readonly IMapper _mapper;
        public CreateRoleCommandHandler(IRoleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<RoleViewModel> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var role = _mapper.Map<Role>(request);
            var createdRole = await _repository.PostAsync(role);
            return _mapper.Map<RoleViewModel>(createdRole);
        }
    }
}
