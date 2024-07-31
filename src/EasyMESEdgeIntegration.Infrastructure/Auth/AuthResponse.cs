using System.Text.Json.Serialization;

namespace EasyMESEdgeIntegration.Infrastructure.Auth;

public class AuthResponse
{
    // [AliasAs("expires_in")]
    // [JsonPropertyName("expires_in")]
    // public DateTime Date { get; set; }

    // [AliasAs("token_type")]
    [JsonPropertyName("token_type")]
    public string TokenType { get; set; }

    // [AliasAs("access_token")]
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }
}





