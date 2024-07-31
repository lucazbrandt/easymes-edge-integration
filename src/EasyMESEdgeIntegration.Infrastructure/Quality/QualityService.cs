using AutoMapper;
using EasyMESEdgeIntegration.Application.Quality.Services;
using EasyMESEdgeIntegration.Domain.Quality.Models;
using EasyMESEdgeIntegration.Infrastructure.Auth;
using EasyMESEdgeIntegration.Infrastructure.Commons;
using Microsoft.Extensions.Options;
using Refit;

namespace EasyMESEdgeIntegration.Infrastructure.Quality;

public class QualityService : IQualityService
{
    private readonly IMapper _mapper;
    private readonly EasyMESEdgeConfig config;

    public QualityService(IMapper mapper, IOptions<EasyMESEdgeConfig> options)
    {
        config = options.Value;
        _mapper = mapper;
    }

    public async Task CreateCollectionFormAnswerAutomated(CollectionFormAnswerAutomated model)
    {
        var request = _mapper.Map<CreateCollectionFormAnswerAutomatedEasyMESRequest>(model);

        var qualityIntegration = RestService.For<IQualityIntegration>(new HttpClient(new AuthHeaderHandler(config, new HttpClientHandler()))
        {
            BaseAddress = new Uri(config.BaseUrl)
        }
        );

        await qualityIntegration.CreateCollectionFormAnswerAutomated(request);
    }
}