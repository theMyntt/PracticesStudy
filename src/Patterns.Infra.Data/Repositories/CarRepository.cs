using System.Linq.Expressions;
using Patterns.Infra.Data.Abstractions;
using Patterns.Infra.Data.Entities;

namespace Patterns.Infra.Data.Repositories;

public class CarRepository : ICarRepository
{
    private readonly IBaseRepository<Car> _repository;

    public CarRepository(IBaseRepository<Car> repository) => _repository = repository;
    
    public async Task<IEnumerable<Car>> FindAllAsync(int page, int limit)
    {
        return await _repository.FindAllAsync(page, limit);
    }

    public async Task SaveAsync(Car input)
    { 
        await _repository.SaveAsync(input);
    }

    public async Task DeleteAsync(Expression<Func<Car, bool>> filter)
    {
        await _repository.DeleteAsync(filter);
    }

    public async Task EditAsync(Car input)
    {
        await _repository.EditAsync(input);
    }
}