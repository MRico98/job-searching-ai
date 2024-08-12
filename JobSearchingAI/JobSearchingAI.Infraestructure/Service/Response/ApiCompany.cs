using Newtonsoft.Json;

namespace JobSearchingAI.Infraestructure.Service.Response;

public class ApiCompany
{
    [JsonProperty("display_name")]
    public string DisplayName { get; set; }
}