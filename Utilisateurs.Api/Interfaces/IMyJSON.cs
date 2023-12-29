using Refit;

namespace Utilisateurs.Api.Interfaces
{
    public interface IMyJSON
    {
        [Get("/db")]
        Task<object?> GetMyJSON();
    }
}
