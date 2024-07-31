using EasyMESEdgeIntegration.Infrastructure.Commons;
using EasyMESEdgeIntegration.Application.Health.Services;
using Microsoft.Extensions.Options;
using Refit;
using EasyMESEdgeIntegration.Infrastructure.Auth;

namespace EasyMESEdgeIntegration.Infrastructure.Health;

public class HealthService : IHealthService
{
    private readonly EasyMESEdgeConfig config;

    public HealthService(IOptions<EasyMESEdgeConfig> options)
    {
        config = options.Value;
    }

    public async Task Live()
    {
        var healthIntegration = RestService.For<IHealthIntegration>(new HttpClient(new AuthHeaderHandler(config, new HttpClientHandler()))
            {
                BaseAddress = new Uri(config.BaseUrl)
            }
        );

        await healthIntegration.Live();
    }
}