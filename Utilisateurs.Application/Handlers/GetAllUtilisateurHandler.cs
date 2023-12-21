using AutoMapper;
using MediatR;
using Utilisateurs.Application.Queries;
using Utilisateurs.Domain.DTOs.UtilisateurDTOs;
using Utilisateurs.Domain.Entities;
using Utilisateurs.Domain.Interfaces;

namespace Utilisateurs.Application.Handlers
{
    public class GetAllUtilisateurHandler : IRequestHandler<GetAllUtilisateurQuery, List<UtilisateurDTO>>
    {
        private readonly IGenericRepository<Utilisateur> _repository;
        private readonly IMapper _mapper;
        public GetAllUtilisateurHandler(IUtilisateurRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<UtilisateurDTO>> Handle(GetAllUtilisateurQuery request, CancellationToken cancellationToken)
        {
            var utilisateurs = await _repository.GetAllAsync();
            return _mapper.Map<List<UtilisateurDTO>>(utilisateurs);
        }
    }
}
