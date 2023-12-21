using MediatR;
using Utilisateurs.Application.Queries;
using Utilisateurs.Domain.Entities;
using Utilisateurs.Domain.Interfaces;

namespace Utilisateurs.Application.Handlers
{
    public class GetAllUtilisateurHandler : IRequestHandler<GetAllUtilisateurQuery, List<Utilisateur>>
    {
        private readonly IGenericRepository<Utilisateur> _repository;
        public GetAllUtilisateurHandler(IUtilisateurRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Utilisateur>> Handle(GetAllUtilisateurQuery request, CancellationToken cancellationToken)
        {
            var utilisateurs = await _repository.GetAllAsync();
            return utilisateurs;
        }
    }
}
