using OneOf;
using Patterns.Application.Abstractions;
using Patterns.Application.DTOs.Car;
using Patterns.Domain.Aggregates;
using Patterns.Domain.Entities;
using Patterns.Infra.Data.Abstractions;

namespace Patterns.Application.UseCases.Car;

public class CreateCarUseCase : ICreateCarUseCase
{
    private readonly ICarRepository _repository;
    private readonly ICarMapper _mapper;

    public CreateCarUseCase(ICarRepository repository, ICarMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<OneOf<StandardResponse, StandardResponse>> Run(CreateCarDTO input)
    {
        var aggregate = new CarAggregate(input.Corp, input.Model);

        await _repository.SaveAsync(_mapper.ToPersistance(aggregate));
        
        return OneOf<StandardResponse, StandardResponse>.FromT0(new StandardResponse
        {
            Message = "Created.",
            StatusCode = 201
        });
    }
}