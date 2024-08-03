using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using JobSearchingAI.JobFetcher.Service;
using JobSearchingAI.Core.Core;
using JobSearchingAI.Infraestructure.Service;
using System.Text;

EncodingProvider provider = System.Text.CodePagesEncodingProvider.Instance;
Encoding.RegisterProvider(provider);

var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
    })
    .ConfigureServices((context, services) =>
    {
        var connectionString = context.Configuration.GetConnectionString("DefaultConnection");
        if (connectionString == null)
        {
            throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        }
        services.AddSingleton<IConsoleService, ConsoleService>(sp => new ConsoleService(connectionString, sp.GetRequiredService<IExternalDataFetcher>()));
        services.AddHttpClient<IExternalDataFetcher, ExternalDataFetcher>();
    })
    .Build();

var service = host.Services.GetRequiredService<IConsoleService>();
await service.RunAsync();