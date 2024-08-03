using Newtonsoft.Json;

namespace JobSearchingAI.Infraestructure.Service.Response;

public class ApiLocation
{
    [JsonProperty("__CLASS__")]
    public string Class { get; set; }
    public List<string> Area { get; set; }
    public string DisplayName { get; set; }
}