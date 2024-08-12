namespace JobSearchingAI.Core.Entities;

public class Job : IEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    
    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }    
}
