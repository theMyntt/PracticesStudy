using OneOf;
using Patterns.Application.Abstractions;
using Patterns.Application.DTOs.Car;
using Patterns.Application.Responses.Car;
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
    public class FindAllCarUseCase : IFindAllCarUseCase
    {
        private readonly ICarRepository _repository;
        private readonly ICarMapper _mapper;

        public FindAllCarUseCase(ICarRepository repository, ICarMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<FindAllCarResponse, StandardResponse>> Run(FindAllDTO input)
        {
            try
            {
                var entities = await _repository.FindAllAsync(input.page - 1, input.limit);
                var cars = entities
                    .Select(entity => _mapper.ToDomain(entity))
                    .ToList();

                var total = await _repository.CountAsync();

                return new FindAllCarResponse
                {
                    Cars = cars,
                    Page = input.page,
                    InPage = cars.Count,
                    TotalPages = (int)Math.Ceiling((double)total / input.limit),
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
