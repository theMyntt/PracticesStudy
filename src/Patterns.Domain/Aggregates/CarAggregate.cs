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
        this.Corp = Corp.ToUpper();
        this.Model = Model.ToUpper();

        Id = Guid.NewGuid();
        CreatedAt = GenerateTimestamp.Perform();
        UpdatedAt = null;
    }

    public CarAggregate(Guid Id, string Corp, string Model, long CreatedAt)
    {
        this.Id = Id;
        this.Corp = Corp.ToUpper();
        this.Model = Model.ToUpper();
        this.CreatedAt = CreatedAt;

        UpdatedAt = GenerateTimestamp.Perform();
    }

    public CarAggregate(Guid Id, string Corp, string Model, long CreatedAt, long? UpdatedAt)
    {
        this.Id = Id;
        this.Corp = Corp.ToUpper();
        this.Model = Model.ToUpper();
        this.CreatedAt = CreatedAt;
        this.UpdatedAt = UpdatedAt;
    }
}