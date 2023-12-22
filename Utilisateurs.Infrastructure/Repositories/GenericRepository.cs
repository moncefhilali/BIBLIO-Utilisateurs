using Microsoft.EntityFrameworkCore;
using Utilisateurs.Domain.Interfaces;

namespace Utilisateurs.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DBC _dbc;
        private DbSet<T> _table;

        public GenericRepository(DBC dbc)
        {
            _dbc = dbc;
            _table = _dbc.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = await _table.ToListAsync();
            return entities;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _table.FindAsync(id);
            return entity;
        }

        public async Task<T> PostAsync(T entity)
        {
            await _table.AddAsync(entity);
            await _dbc.SaveChangesAsync();
            return entity;
        }

        public async Task<T> PutAsync(int id, T entity)
        {
            var data = await _table.FindAsync(id);
            if (data is null)
                return null;

            _dbc.Entry(data).CurrentValues.SetValues(entity);
            await _dbc.SaveChangesAsync();
            return data;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _table.FindAsync(id);
            if (entity is null)
                return;

            _table.Remove(entity);
            await _dbc.SaveChangesAsync();
        }
    }
}
