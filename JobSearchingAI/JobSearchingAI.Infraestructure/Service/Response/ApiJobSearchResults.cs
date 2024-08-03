using Newtonsoft.Json;

namespace JobSearchingAI.Infraestructure.Service.Response;

public class ApiJobSearchResults
{
    [JsonProperty("__CLASS__")]
    public string Class { get; set; }
    public int Count { get; set; }
    public decimal Mean { get; set; }
    public List<ApiJob> Results { get; set; }
}