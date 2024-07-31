using System.Net.Http.Headers;
using EasyMESEdgeIntegration.Infrastructure.Commons;
using Refit;

namespace EasyMESEdgeIntegration.Infrastructure.Auth;

public class AuthHeaderHandler : DelegatingHandler
{
    private readonly EasyMESEdgeConfig _config;

    public AuthHeaderHandler(EasyMESEdgeConfig config, HttpMessageHandler innerHandler) : base(innerHandler)
    {
        _config = config;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var authIntegration = RestService.For<IAuthIntegration>(_config.AuthUrl);

        var authData = new Dictionary<string, string>
        {
            { "client_id", _config.ClientId },
            { "client_secret", _config.Secret },
            { "grant_type", _config.GrantType }
        };

        var response = await authIntegration.GenerateToken(authData);

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", response.AccessToken);

        return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
    }
}