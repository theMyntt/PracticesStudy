using Patterns.Application.DTOs.Car;
using Patterns.Domain.Entities;

namespace Patterns.Application.Abstractions;

public interface ICreateCarUseCase : IUseCase<StandardResponse, StandardResponse, CreateCarDTO>
{
    
}