using AutoMapper;
using EasyMESEdgeIntegration.Application.Quality;

namespace EasyMESEdgeIntegration.WebApi.Quality;

public class CreateCollectionFormAnswerAutomatedProfile : Profile
{
    public CreateCollectionFormAnswerAutomatedProfile()
    {
        CreateMap<CreateCollectionFormAnswerAutomatedRequest, CreateCollectionFormAnswerAutomatedCommand>();
        CreateMap<CreateCollectionItemFormAnswerAutomatedRequest, CreateCollectionItemFormAnswerAutomatedCommand>();
    }
}