using Newtonsoft.Json;

namespace JobSearchingAI.Infraestructure.Service.Response;

public class ApiCompany
{
    [JsonProperty("__CLASS__")]
    public string Class { get; set; }
    public string DisplayName { get; set; }
}