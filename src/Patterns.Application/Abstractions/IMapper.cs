namespace Patterns.Application.Abstractions;

public interface IMapper<Entity, Aggregate>
{
    Entity ToPersistance(Aggregate input);
    Aggregate ToDomain(Entity input);
}