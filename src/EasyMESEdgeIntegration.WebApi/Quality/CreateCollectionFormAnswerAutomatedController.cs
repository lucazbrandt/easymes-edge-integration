using AutoMapper;
using EasyMESEdgeIntegration.Application.Quality;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EasyMESEdgeIntegration.WebApi.Quality;

[ApiController]
[Route("collection-form-answer/automated")]
public class CreateCollectionFormAnswerAutomatedController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    private readonly ILogger<CreateCollectionFormAnswerAutomatedController> _logger;

    public CreateCollectionFormAnswerAutomatedController(IMediator mediator, IMapper mapper, ILogger<CreateCollectionFormAnswerAutomatedController> logger)
    {
        _mediator = mediator;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpPost(Name = "CreateCollectionFormAnswerAutomated")]
    public async Task<IActionResult> CreateCollectionFormAnswerAutomated(CreateCollectionFormAnswerAutomatedRequest request)
    {
        _logger.LogInformation("Creating a collection form answr automated");

        var command = _mapper.Map<CreateCollectionFormAnswerAutomatedCommand>(request);

        await _mediator.Send(command);

        return Ok();
    }
}