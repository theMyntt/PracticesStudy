using System.ComponentModel.DataAnnotations;

namespace Patterns.Application.DTOs.Car;

public record CreateCarDTO(
    [Required] string Corp, 
    [Required] string Model);