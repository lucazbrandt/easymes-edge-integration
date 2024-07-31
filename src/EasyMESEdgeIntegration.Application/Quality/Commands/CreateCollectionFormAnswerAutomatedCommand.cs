using MediatR;

namespace EasyMESEdgeIntegration.Application.Quality;

public class CreateCollectionFormAnswerAutomatedCommand : IRequest
{
    public string Code { get; set; }
    public string Ip { get; set; }
    public string ProductionOrderBatch { get; set; }
    public string Barcode { get; set; }
    public string Status { get; set; }
    public IEnumerable<CreateCollectionItemFormAnswerAutomatedCommand> ItemAnswers { get; set; }
}