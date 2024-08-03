namespace JobSearchingAI.Core.Entities;

public class JobSearchResults
{
    public int Count { get; set; }
    public decimal Mean { get; set; }
    public List<Job> Results { get; set; }
}