using Refit;

namespace EasyMESEdgeIntegration.Infrastructure.Quality;

public interface IQualityIntegration
{
    [Post("/quality/data-collection/collection-form-answer/automated")]
    Task CreateCollectionFormAnswerAutomated(CreateCollectionFormAnswerAutomatedEasyMESRequest request);
}