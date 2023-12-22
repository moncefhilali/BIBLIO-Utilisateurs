using AutoMapper;
using MediatR;
using Utilisateurs.Domain.Interfaces;
using Utilisateurs.Application.ViewModels;

namespace Utilisateurs.Application.Utilisateurs.Queries
{
    public class GetAllUtilisateurQueryHandler : IRequestHandler<GetAllUtilisateurQuery, List<UtilisateurViewModel>>
    {
        private readonly IUtilisateurRepository _repository;
        private readonly IMapper _mapper;
        public GetAllUtilisateurQueryHandler(IUtilisateurRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<UtilisateurViewModel>> Handle(GetAllUtilisateurQuery request, CancellationToken cancellationToken)
        {
            var utilisateurs = await _repository.GetAllAsync();
            return _mapper.Map<List<UtilisateurViewModel>>(utilisateurs);
        }
    }
}
