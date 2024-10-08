using Patterns.Application.DTOs.Car;
using Patterns.Application.Responses.Car;
using Patterns.Domain.Entities;

namespace Patterns.Application.Abstractions;

public interface ICreateCarUseCase : IUseCase<CreateCarResponse, StandardResponse, CreateCarDTO>
{
    
}