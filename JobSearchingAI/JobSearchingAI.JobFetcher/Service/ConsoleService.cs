using JobSearchingAI.Core.Core;

namespace JobSearchingAI.JobFetcher.Service;

public class ConsoleService(string connectionString, IExternalDataFetcher externalDataFetcher) : IConsoleService
{
    private readonly string _connectionString = connectionString;
    private readonly IExternalDataFetcher _externalDataFetcher = externalDataFetcher;

    public async Task RunAsync()
    {
        await _externalDataFetcher.FetchDataAsync();
        Console.WriteLine(_connectionString);
    }
}