using Patterns.Domain.Aggregates;
using Patterns.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Application.Responses.Car
{
    public class FindAllCarResponse : StandardResponse
    {
        public IEnumerable<CarAggregate>? Cars { get; set; }
        public int Page { get; set; }
        public int InPage { get; set; }
        public int TotalPages { get; set; }
    }
}
