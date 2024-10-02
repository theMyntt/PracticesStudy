using Patterns.Application.DTOs.Car;
using Patterns.Application.Responses.Car;
using Patterns.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Application.Abstractions
{
    public interface IFindAllCarUseCase : IUseCase<FindAllCarResponse, StandardResponse, FindAllDTO>
    {
    }
}
