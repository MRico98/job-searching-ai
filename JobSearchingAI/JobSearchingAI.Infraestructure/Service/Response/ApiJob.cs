using Newtonsoft.Json;

namespace JobSearchingAI.Infraestructure.Service.Response;

public class ApiJob
{
    public string Title { get; set; }
    public string Description { get; set; }
    public ApiCompany Company { get; set; }
}