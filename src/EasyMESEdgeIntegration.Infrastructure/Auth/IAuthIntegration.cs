using Refit;

namespace EasyMESEdgeIntegration.Infrastructure.Auth;

public interface IAuthIntegration
{
    [Post("/token")]
    Task<AuthResponse> GenerateToken([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, string> data);
}