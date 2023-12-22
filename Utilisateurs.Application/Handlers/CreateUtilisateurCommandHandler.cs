using AutoMapper;
using MediatR;
using Utilisateurs.Application.Commands;
using Utilisateurs.Domain.DTOs.UtilisateurDTOs;
using Utilisateurs.Domain.Entities;
using Utilisateurs.Domain.Interfaces;

namespace Utilisateurs.Application.Handlers
{
    public class CreateUtilisateurCommandHandler : IRequestHandler<CreateUtilisateurCommand, UtilisateurDTO>
    {
        private readonly IUtilisateurRepository _repository;
        private readonly IMapper _mapper;
        public CreateUtilisateurCommandHandler(IUtilisateurRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UtilisateurDTO> Handle(CreateUtilisateurCommand request, CancellationToken cancellationToken)
        {
            var utilisateur = _mapper.Map<Utilisateur>(request.NewUtilisateur);
            var createUtilisateur = await _repository.PostAsync(utilisateur);
            return _mapper.Map<UtilisateurDTO>(createUtilisateur);
        }
    }
}
