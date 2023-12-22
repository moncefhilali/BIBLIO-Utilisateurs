namespace Utilisateurs.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> PutAsync(int id, T entity);
        Task<T> PostAsync(T entity);
        Task DeleteAsync(int id);

    }
}
