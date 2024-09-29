namespace Patterns.Domain.Entities;

public class StandardResponse
{
    public required string Message { get; init; }
    public int StatusCode { get; init; }
}