using AutoMapper;
using MediatR;
using Utilisateurs.Application.Queries;
using Utilisateurs.Domain.DTOs.UtilisateurDTOs;
using Utilisateurs.Domain.Interfaces;

namespace Utilisateurs.Application.Handlers
{
    public class GetAllUtilisateurQueryHandler : IRequestHandler<GetAllUtilisateurQuery, List<UtilisateurDTO>>
    {
        private readonly IUtilisateurRepository _repository;
        private readonly IMapper _mapper;
        public GetAllUtilisateurQueryHandler(IUtilisateurRepository repository, IMapper mapper)
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
