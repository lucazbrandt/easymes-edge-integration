namespace EasyMESEdgeIntegration.Domain.Quality.Models;

public class CollectionFormAnswerAutomated
{
    public string Code { get; }
    public string Ip { get; }
    public string ProductionOrderBatch { get; }
    public string Barcode { get; }
    public string Status { get; }
    public List<CollectionItemFormAnswerAutomated> ItemAnswers { get; private set; }

    public CollectionFormAnswerAutomated(
        string Code,
        string Ip,
        string ProductionOrderBatch,
        string Barcode,
        string Status)
    {
        this.Code = Code;
        this.Ip = Ip;
        this.ProductionOrderBatch = ProductionOrderBatch;
        this.Barcode = Barcode;
        this.Status = Status;
        ItemAnswers = new List<CollectionItemFormAnswerAutomated>();
    }

    public void AddItemAnswer(CollectionItemFormAnswerAutomated ItemAnswer)
    {
        ItemAnswers.Add(ItemAnswer);
    }
}