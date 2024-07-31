using BrasilApiKata.Infrastructure.Holidays;
using BrasilKata.Application.Holidays.Services;
using EasyMESEdgeIntegration.Application.Health.Services;
using EasyMESEdgeIntegration.Application.Quality.Services;
using EasyMESEdgeIntegration.Infrastructure.Health;
using EasyMESEdgeIntegration.Infrastructure.Quality;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EasyMESEdgeIntegration.Infrastructure.Commons;

public static class EasyMESEdgeExtension
{
    public static IServiceCollection AddEasyMESEdge(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<EasyMESEdgeConfig>(opts => configuration.GetSection(EasyMESEdgeConfig.EasyMESEdge).Bind(opts));
        services.AddScoped<IHealthService, HealthService>();
        services.AddScoped<IQualityService, QualityService>();

        return services;
    }
}