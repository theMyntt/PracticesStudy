using Patterns.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Domain.Entities.Responses.Car
{
    public class FindAllCarResponse : StandardResponse
    {
        public IEnumerable<CarAggregate>? Cars { get; set; }
    }
}
