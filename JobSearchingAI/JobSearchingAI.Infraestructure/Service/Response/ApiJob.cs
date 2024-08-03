using Newtonsoft.Json;

namespace JobSearchingAI.Infraestructure.Service.Response;

public class ApiJob
{
    [JsonProperty("__CLASS__")]
    public string Class { get; set; }
    public string Id { get; set; }
    public decimal SalaryMin { get; set; }
    public decimal SalaryMax { get; set; }
    public string Description { get; set; }
    public string Adref { get; set; }
    public string ContractTime { get; set; }
    public ApiCompany Company { get; set; }
    public ApiCategory Category { get; set; }
    public string RedirectUrl { get; set; }
    public DateTime Created { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public string ContractType { get; set; }
    public string Title { get; set; }
    public ApiLocation Location { get; set; }
}