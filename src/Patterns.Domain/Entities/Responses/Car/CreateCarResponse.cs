using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Domain.Entities.Responses.Car
{
    public class CreateCarResponse : StandardResponse
    {
        public Guid Id { get; init; }
    }
}
