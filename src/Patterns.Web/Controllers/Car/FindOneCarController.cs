using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patterns.Application.Abstractions;

namespace Patterns.Web.Controllers.Car
{
    [Route("api/car")]
    [Tags("Car")]
    [ApiController]
    public class FindOneCarController : ControllerBase
    {
        private readonly IFindOneCarUseCase _useCase;

        public FindOneCarController(IFindOneCarUseCase useCase) => _useCase = useCase;

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Perform([FromRoute] Guid id)
        {
            var response = await _useCase.Run(id);

            if (response.IsT1)
                return StatusCode(response.AsT1.StatusCode, response.AsT1);

            return StatusCode(200, response.AsT0);
        }
    }
}
