using AutoMapper;
using MediatR;
using Utilisateurs.Application.Utilisateurs.ViewModel;
using Utilisateurs.Domain.Entities;
using Utilisateurs.Domain.Interfaces;

namespace Utilisateurs.Application.Utilisateurs.Commands
{
    public class CreateUtilisateurCommandHandler : IRequestHandler<CreateUtilisateurCommand, UtilisateurViewModel>
    {
        private readonly IUtilisateurRepository _repository;
        private readonly IMapper _mapper;
        public CreateUtilisateurCommandHandler(IUtilisateurRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UtilisateurViewModel> Handle(CreateUtilisateurCommand request, CancellationToken cancellationToken)
        {
            var utilisateur = _mapper.Map<Utilisateur>(request);
            var createUtilisateur = await _repository.PostAsync(utilisateur);
            return _mapper.Map<UtilisateurViewModel>(createUtilisateur);
        }
    }
}
