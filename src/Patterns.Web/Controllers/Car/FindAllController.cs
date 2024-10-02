using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patterns.Application.Abstractions;
using Patterns.Application.DTOs.Car;

namespace Patterns.Web.Controllers.Car
{
    [Route("api/car")]
    [Tags("Car")]
    [ApiController]
    public class FindAllController : ControllerBase
    {
        private readonly IFindAllCarUseCase _useCase;

        public FindAllController(IFindAllCarUseCase useCase) => _useCase = useCase;

        [HttpGet]
        public async Task<IActionResult> Perform([FromQuery] FindAllDTO input)
        {
            var result = await _useCase.Run(input);

            if (result.IsT1)
                return StatusCode(result.AsT1.StatusCode, result.AsT1);

            return StatusCode(result.AsT0.StatusCode, result.AsT0);
        }
    }
}
