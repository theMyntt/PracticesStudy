using Patterns.Shared;

namespace Patterns.Domain.Aggregates;

public class CarAggregate
{
    public Guid Id { get; private set; }
    public string Corp { get; private set; }
    public string Model { get; private set; }
    public long CreatedAt { get; private set; }
    public long? UpdatedAt { get; private set; }

    public CarAggregate(string Corp, string Model)
    {
        this.Corp = Corp;
        this.Model = Model;
        
        Id = Guid.NewGuid();
        CreatedAt = GenerateTimestamp.Perform();
        UpdatedAt = null;
    }
}