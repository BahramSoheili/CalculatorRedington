using CalculatorManagement.Dtos;
using RedingtonApi.Queries;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RedingtonApi.Mapping;

namespace RedingtonApi.Controllers;

[Route("api/[controller]")]
public class ProbabilityController : ControllerBase
{
    private readonly ILogger<ProbabilityController> _logger;
    private readonly IMediator _mediator;

    public ProbabilityController(ILogger<ProbabilityController> logger, 
        IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpPost("CalculateProbability")]
    public async Task<IActionResult> Post([FromBody] ProbabilityDto probabilityDto)
    {
        var result = await _mediator.Send(new GetProbabilitiesQuery(probabilityDto));
        return result.Match<IActionResult>(
           p => Ok(p),
           failed => BadRequest(failed.MapToResponse()));
    }

}