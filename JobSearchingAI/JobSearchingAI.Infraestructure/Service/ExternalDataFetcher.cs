using Newtonsoft.Json.Converters;
using JobSearchingAI.Core.Core;
using JobSearchingAI.Core.Entities;
using Newtonsoft.Json;
using JobSearchingAI.Infraestructure.Service.Response;

namespace JobSearchingAI.Infraestructure.Service;

public class ExternalDataFetcher(HttpClient httpClient) : IExternalDataFetcher
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<JobSearchResults> FetchDataAsync()
    {
        var response = await _httpClient.GetAsync("https://api.adzuna.com/v1/api/jobs/gb/search/1?app_id=6ea5d302&app_key=dfd7dc3422fa670bbb494489dbcd76dd");
        response.EnsureSuccessStatusCode();
        var jsonString = await response.Content.ReadAsStringAsync();
        Console.WriteLine(jsonString);
        //Console.WriteLine(response.Content);
        //var apiResponse = JsonConvert.DeserializeObject<ApiJobSearchResults>(jsonString);
        return null;
    }
}