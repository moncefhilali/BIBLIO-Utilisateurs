using MediatR;
using Utilisateurs.Application.Queries;
using Utilisateurs.Domain.Entities;
using Utilisateurs.Domain.Interfaces;

namespace Utilisateurs.Application.Handlers
{
    public class GetAllUtilisateurHandler : IRequestHandler<GetAllUtilisateurQuery, List<Utilisateur>>
    {
        private readonly IUtilisateurRepository _repository;
        public GetAllUtilisateurHandler(IUtilisateurRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Utilisateur>> Handle(GetAllUtilisateurQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}
