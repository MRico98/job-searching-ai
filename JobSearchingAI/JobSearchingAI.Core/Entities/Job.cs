namespace JobSearchingAI.Core.Entities;

public class Job : IEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int SubrogatedId { get; set; }
    public string? Description { get; set; }
    
    public int CompanyId { get; set; }
    public Company? Company { get; set; }
    
    public Recommendation? Recommendation { get; set; }
}
