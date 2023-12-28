using AutoMapper;
using MediatR;
using Utilisateurs.Application.UtilisateurRoles.ViewModel;
using Utilisateurs.Domain.Entities;
using Utilisateurs.Domain.Interfaces;

namespace Utilisateurs.Application.UtilisateurRoles.Commands
{
    public class CreateUtilisateurRoleCommandHandler : IRequestHandler<CreateUtilisateurRoleCommand, UtilisateurRoleViewModel>
    {
        private readonly IUtilisateurRoleRepository _repository;
        private readonly IMapper _mapper;
        public CreateUtilisateurRoleCommandHandler(IUtilisateurRoleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UtilisateurRoleViewModel> Handle(CreateUtilisateurRoleCommand request, CancellationToken cancellationToken)
        {
            var utilisateurRole = _mapper.Map<UtilisateurRole>(request);
            var createdUtilisateurRole = await _repository.PostAsync(utilisateurRole);
            return _mapper.Map<UtilisateurRoleViewModel>(createdUtilisateurRole);
        }
    }
}
