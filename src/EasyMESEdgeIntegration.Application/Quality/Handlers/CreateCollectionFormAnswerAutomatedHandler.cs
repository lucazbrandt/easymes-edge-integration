using EasyMESEdgeIntegration.Application.Quality.Services;
using EasyMESEdgeIntegration.Domain.Quality.Models;
using MediatR;
using Microsoft.Extensions.Logging;

namespace EasyMESEdgeIntegration.Application.Quality.Handlers;

public class CreateCollectionFormAnswerAutomatedHandler : IRequestHandler<CreateCollectionFormAnswerAutomatedCommand>
{
    private readonly IQualityService _qualityService;
    private readonly ILogger<CreateCollectionFormAnswerAutomatedHandler> _logger;

    public CreateCollectionFormAnswerAutomatedHandler(IQualityService qualityService, ILogger<CreateCollectionFormAnswerAutomatedHandler> logger)
    {
        _logger = logger;
        _qualityService = qualityService;
    }

    public async Task Handle(CreateCollectionFormAnswerAutomatedCommand command, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Creating collection form answer automated");

        var model = CreateModel(command);

        await _qualityService.CreateCollectionFormAnswerAutomated(model);

        _logger.LogInformation("Collection form answer automated successfully created");
    }

    private static CollectionFormAnswerAutomated CreateModel(CreateCollectionFormAnswerAutomatedCommand command)
    {
        var model = new CollectionFormAnswerAutomated(
                    command.Code,
                    command.Ip,
                    command.ProductionOrderBatch,
                    command.Barcode,
                    command.Status);

        foreach (CreateCollectionItemFormAnswerAutomatedCommand commandItem in command.ItemAnswers)
        {
            model.AddItemAnswer(
                new CollectionItemFormAnswerAutomated(
                    commandItem.Code,
                    commandItem.answer,
                    commandItem.Status));
        }

        return model;
    }
}