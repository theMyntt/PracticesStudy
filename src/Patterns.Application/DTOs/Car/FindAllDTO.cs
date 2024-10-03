using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Application.DTOs.Car
{
    public record FindAllDTO
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Page must be greater than 0")]
        public int page { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Limit must be between 1 and 100")]
        public int limit { get; set; }
    };
}
