using JobSearchingAI.Core.Entities;

namespace JobSearchingAI.Core.Core;

public interface IExternalDataFetcher
{
    Task<byte[]> FetchDataAsync(string url);
    Task<byte[]> FetchDataAsync(string url, Dictionary<string, string> queryParams);

}