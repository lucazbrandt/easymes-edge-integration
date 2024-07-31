using EasyMESEdgeIntegration.Domain.Quality.Models;

namespace EasyMESEdgeIntegration.Application.Quality.Services;

public interface IQualityService
{
    Task CreateCollectionFormAnswerAutomated(CollectionFormAnswerAutomated model);
}