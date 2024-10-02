using OneOf;
using Patterns.Application.Abstractions;
using Patterns.Application.DTOs.Car;
using Patterns.Domain.Aggregates;
using Patterns.Domain.Entities;
using Patterns.Domain.Entities.Responses.Car;
using Patterns.Infra.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Application.UseCases.Car
{
    public class FindAllUseCase : IFindAllCarUseCase
    {
        private readonly ICarRepository _repository;
        private readonly ICarMapper _mapper;

        public FindAllUseCase(ICarRepository repository, ICarMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<FindAllCarResponse, StandardResponse>> Run(FindAllDTO input)
        {
            if (input.limit > 15)
            {
                return new StandardResponse
                {
                    Message = "Limit cant be greater than 15",
                    StatusCode = 400
                };
            }

            try
            {
                var entities = await _repository.FindAllAsync(input.page - 1, input.limit);
                List<CarAggregate> cars = [];

                foreach (var item in entities)
                {
                    cars.Add(_mapper.ToDomain(item));
                }

                return new FindAllCarResponse
                {
                    Cars = cars,
                    Message = "Cars Found",
                    StatusCode = 200,
                };
            }
            catch (Exception)
            {
                return new StandardResponse
                {
                    Message = "Internal Server Error",
                    StatusCode = 500
                };
            }
        }
    }
}
