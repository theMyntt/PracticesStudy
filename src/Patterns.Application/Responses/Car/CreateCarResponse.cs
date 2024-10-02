using Patterns.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Application.Responses.Car
{
    public class CreateCarResponse : StandardResponse
    {
        public Guid Id { get; init; }
    }
}
