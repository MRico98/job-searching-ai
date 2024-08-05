using JobSearchingAI.Core.Core;
using Microsoft.Extensions.Logging;
using JobSearchingAI.Infraestructure.Exceptions;

namespace JobSearchingAI.Infraestructure.Service;

public class ExternalDataFetcher(HttpClient httpClient, ILogger<ExternalDataFetcher> logger) : IExternalDataFetcher
{
    private readonly HttpClient _httpClient = httpClient;
    private readonly ILogger _logger = logger;

    public async Task<byte[]> FetchDataAsync(string url)
    {
        try
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync(url);

            httpResponseMessage.EnsureSuccessStatusCode();

            return await httpResponseMessage.Content.ReadAsByteArrayAsync();
        }
        catch(HttpRequestException)
        {
            _logger.LogError("Invalid Http request: Check the ExternalDataFetcher class");
            throw new InvalidHttpRequestException("Invalid Http request: Check the ExternalDataFetcher class");
        }
    }

    public async Task<byte[]> FetchDataAsync(string url, Dictionary<string, string> queryParams)
    {
        try
        {
            var queryString = new FormUrlEncodedContent(queryParams).ReadAsStringAsync().Result;
            var requestUrl = $"{url}?{queryString}";
            
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync(requestUrl);

            httpResponseMessage.EnsureSuccessStatusCode();

            return await httpResponseMessage.Content.ReadAsByteArrayAsync();
        }
        catch (HttpRequestException)
        {
            _logger.LogError("Invalid Http request: Check the ExternalDataFetcher class");
            throw new InvalidHttpRequestException("Invalid Http request: Check the ExternalDataFetcher class");
        }
    }
}