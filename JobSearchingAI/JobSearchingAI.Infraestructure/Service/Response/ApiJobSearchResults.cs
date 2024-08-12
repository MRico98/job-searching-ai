using Newtonsoft.Json;

namespace JobSearchingAI.Infraestructure.Service.Response;

public class ApiJobSearchResults
{
    public int Count { get; set; }
    public List<ApiJob> Results { get; set; }
}