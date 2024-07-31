namespace EasyMESEdgeIntegration.Domain.Quality.Models;

public class CollectionItemFormAnswerAutomated
{
    public string Code { get; }
    public string Answer { get; }
    public string Status { get; }

    public CollectionItemFormAnswerAutomated(
        string Code,
        string Answer,
        string Status)
    {
        this.Code = Code;
        this.Answer = Answer;
        this.Status = Status;
    }
}