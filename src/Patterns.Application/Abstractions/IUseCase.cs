using OneOf;

namespace Patterns.Application.Abstractions;

public interface IUseCase<TSuccess, TError, TInput>
{
    Task<OneOf<TSuccess, TError>> Run(TInput input);
}