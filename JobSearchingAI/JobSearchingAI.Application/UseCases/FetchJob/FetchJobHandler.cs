using JobSearchingAI.Core.Core;
using JobSearchingAI.Core.Entities;

namespace JobSearchingAI.Application.UseCases.FetchJob;

public class FetchJobHandler
{
    private readonly IRepository<Job> _repository;
    private readonly IExternalDataFetcher _externalDataFetcher;

    public FetchJobHandler(IRepository<Job> repository, IExternalDataFetcher externalDataFetcher)
    {
        _repository = repository;
        _externalDataFetcher = externalDataFetcher;
    }

    public async Task<FetchJobResponse> HandleAsync(FetchJobRequest fetchJobRequest)
    {
        var jobSearchResults = await _externalDataFetcher.FetchDataAsync();
        return null;
    }
}