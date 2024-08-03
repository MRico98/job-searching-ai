using JobSearchingAI.Core.Entities;

namespace JobSearchingAI.Core.Core;

public interface IExternalDataFetcher
{
    Task<JobSearchResults> FetchDataAsync();
}