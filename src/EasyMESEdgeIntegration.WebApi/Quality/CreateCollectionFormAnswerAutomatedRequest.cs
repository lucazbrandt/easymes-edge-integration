namespace EasyMESEdgeIntegration.WebApi.Quality;

public class CreateCollectionFormAnswerAutomatedRequest
{
    public string Code { get; set; }
    public string Ip { get; set; }
    public string ProductionOrderBatch { get; set; }
    public string Barcode { get; set; }
    public string Status { get; set; }
    public IEnumerable<CreateCollectionItemFormAnswerAutomatedRequest> ItemAnswers { get; set; }
}