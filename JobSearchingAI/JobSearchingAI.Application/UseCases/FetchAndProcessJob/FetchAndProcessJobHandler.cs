using System.Text;
using JobSearchingAI.Core.Core;
using JobSearchingAI.Core.Entities;
using JobSearchingAI.Infraestructure.Service.Config;
using JobSearchingAI.Infraestructure.Service.Response;
using Newtonsoft.Json;

namespace JobSearchingAI.Application.UseCases.FetchAndProcessJob;

public class FetchAndProcessJob(IRepository<Job> repository, IExternalDataFetcher externalDataFetcher, ApiSettings apiSettings)
{
    private readonly IRepository<Job> _repository = repository;
    private readonly IExternalDataFetcher _externalDataFetcher = externalDataFetcher;
    private readonly ApiSettings _apiSettings = apiSettings;

    public async Task HandleAsync()
    {
        Dictionary<string, string> dictionary = new()
        {
            { "app_id", "6ea5d302" },
            { "app_key", "dfd7dc3422fa670bbb494489dbcd76dd" }
        };

        string apiUrl = _apiSettings.BaseUrl;
        
        var apiResultBytes = await _externalDataFetcher.FetchDataAsync(apiUrl ,dictionary);
        var apiResultString = Encoding.UTF8.GetString(apiResultBytes);
        var deserealizationObject = JsonConvert.DeserializeObject<ApiJobSearchResults>(apiResultString);
        Console.WriteLine(deserealizationObject.Results[0].SalaryMax);
        
    }
}