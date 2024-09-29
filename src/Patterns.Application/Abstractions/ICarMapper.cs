using Patterns.Domain.Aggregates;
using Patterns.Infra.Data.Entities;

namespace Patterns.Application.Abstractions;

public interface ICarMapper : IMapper<Car, CarAggregate>
{
    
}