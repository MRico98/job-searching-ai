using System.Text;
using JobSearchingAI.Application.UseCases.FetchAndProcessJob;
using JobSearchingAI.Core.Core;
using JobSearchingAI.Infraestructure.Service.Config;
using JobSearchingAI.Infraestructure.Service.Response;
using Newtonsoft.Json;

namespace JobSearchingAI.JobFetcher.Service;

public class ConsoleService(FetchAndProcessJob fetchAndProcessJob) : IConsoleService
{
    private readonly FetchAndProcessJob _fetchAndProcessJob = fetchAndProcessJob;

    public async Task RunAsync()
    {
        await _fetchAndProcessJob.HandleAsync();
    }
}