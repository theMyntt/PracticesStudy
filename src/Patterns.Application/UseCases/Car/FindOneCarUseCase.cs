using OneOf;
using Patterns.Application.Abstractions;
using Patterns.Domain.Aggregates;
using Patterns.Domain.Entities;
using Patterns.Infra.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Application.UseCases.Car
{
    public class FindOneCarUseCase : IFindOneCarUseCase
    {
        private readonly ICarRepository _repository;
        private readonly ICarMapper _mapper;

        public FindOneCarUseCase(ICarRepository repository, ICarMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<CarAggregate, StandardResponse>> Run(Guid input)
        {
            var entity = await _repository.FindOneAsync(filter => filter.Id == input);

            if (entity == null)
                return new StandardResponse
                {
                    Message = "Car not found",
                    StatusCode = 404
                };

            return _mapper.ToDomain(entity);
        }
    }
}
