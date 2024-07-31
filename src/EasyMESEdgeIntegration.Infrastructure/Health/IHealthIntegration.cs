using Refit;

namespace EasyMESEdgeIntegration.Infrastructure.Health;

public interface IHealthIntegration
{
    [Get("/healthz/live")]
    Task Live();
}