using Patterns.Application.DTOs.Car;
using Patterns.Domain.Entities;
using Patterns.Domain.Entities.Responses.Car;

namespace Patterns.Application.Abstractions;

public interface ICreateCarUseCase : IUseCase<CreateCarResponse, StandardResponse, CreateCarDTO>
{
    
}