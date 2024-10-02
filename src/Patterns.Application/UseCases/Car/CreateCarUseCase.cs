using OneOf;
using Patterns.Application.Abstractions;
using Patterns.Application.DTOs.Car;
using Patterns.Domain.Aggregates;
using Patterns.Domain.Entities;
using Patterns.Domain.Entities.Responses.Car;
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

    public async Task<OneOf<CreateCarResponse, StandardResponse>> Run(CreateCarDTO input)
    {
        var aggregate = new CarAggregate(input.Corp, input.Model);

        try
        {
            await _repository.SaveAsync(_mapper.ToPersistance(aggregate));

            return new CreateCarResponse
            {
                Id = aggregate.Id,
                Message = "Created.",
                StatusCode = 201
            };
        }
        catch (Exception e)
        {

            if (e.InnerException != null && e.InnerException.Message.Contains("duplicate entry", StringComparison.CurrentCultureIgnoreCase))
            {
                return new StandardResponse
                {
                    Message = "Car already exists.",
                    StatusCode = 409
                };
            }


            return new StandardResponse
            {
                Message = "Internal Server Error",
                StatusCode = 500
            };
        }
    }
}