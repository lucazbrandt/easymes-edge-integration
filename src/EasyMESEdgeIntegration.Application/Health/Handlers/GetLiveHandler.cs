using EasyMESEdgeIntegration.Application.Health.Queries;
using EasyMESEdgeIntegration.Application.Health.Services;
using MediatR;
using Microsoft.Extensions.Logging;

namespace EasyMESEdgeIntegration.Application.Health.Handlers;

public class GetLiveQueryHandler : IRequestHandler<GetLiveQuery>
{
    private readonly IHealthService _healthService;
    private readonly ILogger<GetLiveQueryHandler> _logger;

    public GetLiveQueryHandler(IHealthService healthService, ILogger<GetLiveQueryHandler> logger)
    {
        _logger = logger;
        _healthService = healthService;
    }

    public async Task Handle(GetLiveQuery query, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Calling edge live method");

        await _healthService.Live();
    }
}