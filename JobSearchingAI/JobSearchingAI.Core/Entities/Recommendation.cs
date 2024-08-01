namespace JobSearchingAI.Core.Entities;

public class Recommendation
{
    public int Id { get; set; }
    public int JobId { get; set; }
    public string? RecommendationText { get; set; }

    public Job? Job { get; set; }
}
