using EasyMESEdgeIntegration.Application.Health.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EasyMESEdgeIntegration.WebApi.Health.GetHolidays;

[ApiController]
[Route("health/live")]
public class GetLiveController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<GetLiveController> _logger;

    public GetLiveController(IMediator mediator, ILogger<GetLiveController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpGet(Name = "Live")]

    public async Task<IActionResult> Get()
    {
        _logger.LogInformation("Sending get live query");

        await _mediator.Send(new GetLiveQuery());

        return NoContent();
    }
}