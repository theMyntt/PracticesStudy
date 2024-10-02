using Microsoft.AspNetCore.Mvc;
using Patterns.Application.Abstractions;
using Patterns.Application.DTOs.Car;

namespace Patterns.Web.Controllers.Car;

[ApiController]
[Route("/api/car/")]
public class CreateCarController : ControllerBase
{
    private readonly ICreateCarUseCase _useCase;

    public CreateCarController(ICreateCarUseCase useCase) => _useCase = useCase;
    
    [HttpPost]
    public async Task<IActionResult> Perform([FromBody] CreateCarDTO input)
    {
        var result = await _useCase.Run(input);

        if (result.IsT1)
            return StatusCode(result.AsT1.StatusCode, result.AsT1);

        return StatusCode(result.AsT0.StatusCode, result.AsT0);
    }
}