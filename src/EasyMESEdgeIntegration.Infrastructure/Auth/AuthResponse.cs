using System.Text.Json.Serialization;

namespace EasyMESEdgeIntegration.Infrastructure.Auth;

public class AuthResponse
{
    [JsonPropertyName("token_type")]
    public string TokenType { get; set; }

    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }
}





