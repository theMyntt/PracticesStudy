using System.Linq.Expressions;
using Patterns.Infra.Data.Entities;

namespace Patterns.Infra.Data.Abstractions;

public interface ICarRepository
{
    Task<IEnumerable<Car>> FindAllAsync(int page, int limit);
    Task SaveAsync(Car input);
    Task DeleteAsync(Expression<Func<Car, bool>> filter);
    Task EditAsync(Car input);
}