using Patterns.Domain.Aggregates;
using Patterns.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Application.Abstractions
{
    public interface IFindOneCarUseCase : IUseCase<CarAggregate, StandardResponse, Guid>
    {
    }
}
