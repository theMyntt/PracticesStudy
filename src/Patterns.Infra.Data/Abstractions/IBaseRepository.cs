using System.Linq.Expressions;

namespace Patterns.Infra.Data.Abstractions;

public interface IBaseRepository<T>
{
    Task SaveAsync(T input);
    Task<IEnumerable<T>> FindAllAsync(int page, int limit);
    Task<IEnumerable<T>?> FilterAsync(Expression<Func<T, bool>> filter);
    Task<T?> FindOneAsync(Expression<Func<T, bool>> filter);
    Task DeleteAsync(Expression<Func<T, bool>> filter);
    Task EditAsync(T input);
}