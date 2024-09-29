using Patterns.Application.Abstractions;
using Patterns.Domain.Aggregates;
using Patterns.Infra.Data.Entities;

namespace Patterns.Application.Mappers;

public class CarMapper : ICarMapper
{
    public Car ToPersistance(CarAggregate input)
    {
        return new Car
        {
            Id = input.Id,
            Corp = input.Corp,
            Model = input.Model,
            CreatedAt = input.CreatedAt,
            UpdatedAt = input.UpdatedAt
        };
    }

    public CarAggregate ToDomain(Car input)
    {
        return new CarAggregate(input.Id, input.Corp, input.Model, input.CreatedAt, input.UpdatedAt);
    }
}