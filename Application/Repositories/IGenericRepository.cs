using Domain.Commons;
using System.Linq.Expressions;

namespace Application.Repositories
{
    public interface IGenericRepository<T> where T : IEntity
    {
        Task<Guid> AddAsync(T entity);

        Task DeleteAsync(Guid id);

        Task<IEnumerable<T>> GetAllAsync(
            Expression<Func<T, object>>[]? includes = null,
            Expression<Func<T, bool>>? predicate = null
        );

        Task<int> UpdateAsync(T entity);

        Task<T?> GetByIdAsync(Guid id);

        Task AddRangeAsync(IEnumerable<T> entities);

        void Remove(T entity);

        Task<T[]> GetByIdsAsync(Guid[] ids);
    }
}