namespace JobSearchingAI.Core.Entities;

public class Recommendation : IEntity
{
    public Guid Id { get; set; }
    public Guid JobId { get; set; }
    public string? RecommendationText { get; set; }

    public Job? Job { get; set; }
}
