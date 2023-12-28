using AutoMapper;
using MediatR;
using Utilisateurs.Application.UtilisateurRoles.ViewModel;
using Utilisateurs.Domain.Interfaces;

namespace Utilisateurs.Application.UtilisateurRoles.Queries
{
    public class GetAllUtilisateurRoleQueryHandler : IRequestHandler<GetAllUtilisateurRoleQuery, List<UtilisateurRoleViewModel>>
    {
        private readonly IUtilisateurRoleRepository _repository;
        private readonly IMapper _mapper;
        public GetAllUtilisateurRoleQueryHandler(IUtilisateurRoleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<UtilisateurRoleViewModel>> Handle(GetAllUtilisateurRoleQuery request, CancellationToken cancellationToken)
        {
            var utilisateurRoles = await _repository.GetAllAsync();
            return _mapper.Map<List<UtilisateurRoleViewModel>>(utilisateurRoles);
        }
    }
}
