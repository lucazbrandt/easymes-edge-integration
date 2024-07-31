using AutoMapper;
using EasyMESEdgeIntegration.Domain.Quality.Models;

namespace EasyMESEdgeIntegration.Infrastructure.Quality;

public class CreateCollectionFormAnswerAutomatedEasyMESProfile : Profile
{
    public CreateCollectionFormAnswerAutomatedEasyMESProfile()
    {
        CreateMap<CollectionFormAnswerAutomated, CreateCollectionFormAnswerAutomatedEasyMESRequest>();
        CreateMap<CollectionItemFormAnswerAutomated, CreateCollectionItemFormAnswerAutomatedEasyMESRequest>();
    }
}