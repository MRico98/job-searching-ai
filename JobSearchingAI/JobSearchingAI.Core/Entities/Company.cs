namespace JobSearchingAI.Core.Entities;

public class Company
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Location { get; set; }

    public ICollection<Job>? Jobs { get; set; }
}
