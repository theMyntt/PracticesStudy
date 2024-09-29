namespace Patterns.Infra.Data.Entities;

public class Car
{
    public Guid Id { get; set; }
    public string Corp { get; set; }
    public string Model { get; set; }
    public long CreatedAt { get; set; }
    public long? UpdatedAt { get; set; }
}