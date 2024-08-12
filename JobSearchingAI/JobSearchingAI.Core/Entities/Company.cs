
namespace JobSearchingAI.Core.Entities;

public class Company : IEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Job>? Jobs { get; set; }
}
