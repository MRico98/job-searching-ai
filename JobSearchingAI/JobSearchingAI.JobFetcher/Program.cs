﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using JobSearchingAI.JobFetcher.Service;
using JobSearchingAI.Core.Core;
using JobSearchingAI.Infraestructure.Service;
using Microsoft.Extensions.Logging;
using JobSearchingAI.Infraestructure.Service.Config;
using Microsoft.Extensions.Options;
using JobSearchingAI.Application.UseCases.FetchAndProcessJob;
using JobSearchingAI.Core.Entities;
using JobSearchingAI.Infraestructure.Repositories;
using JobSearchingAI.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using JobSearchingAI.Application.Mappings;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
    })
    .ConfigureLogging(logging =>
    {
        logging.ClearProviders();
        logging.AddConsole();
        logging.AddDebug();
    })
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));
        services.AddSingleton<IExternalDataFetcher, ExternalDataFetcher>();
        services.AddSingleton<IConsoleService, ConsoleService>();
        services.AddTransient<IRepository<Job>, Repository<Job>>();
        services.AddHttpClient<IExternalDataFetcher, ExternalDataFetcher>(); 
        services.Configure<ApiSettings>(context.Configuration.GetSection("ApiSettings"));
        services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<ApiSettings>>().Value);
        services.AddTransient<FetchAndProcessJob>();
        services.AddAutoMapper(typeof(ApplicationMapperProfile).Assembly);
    })
    .Build();

IConsoleService service = host.Services.GetRequiredService<IConsoleService>();
await service.RunAsync();