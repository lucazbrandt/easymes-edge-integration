using System.Text.Json.Serialization;

namespace EasyMESEdgeIntegration.Infrastructure.Quality;

public class CreateCollectionFormAnswerAutomatedEasyMESRequest
{
    public string Code { get; set; }
    public string Ip { get; set; }
    public string ProductionOrderBatch { get; set; }

    [JsonPropertyName("barCode")]
    public string Barcode { get; set; }
    public string Status { get; set; }
    public IEnumerable<CreateCollectionItemFormAnswerAutomatedEasyMESRequest> ItemAnswers { get; set; }
}