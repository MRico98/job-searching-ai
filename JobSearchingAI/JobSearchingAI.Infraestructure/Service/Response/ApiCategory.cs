using Newtonsoft.Json;

namespace JobSearchingAI.Infraestructure.Service.Response;

public class ApiCategory
{
    [JsonProperty("__CLASS__")]
    public string Class { get; set; }
    public string Label { get; set; }
    public string Tag { get; set; }
}