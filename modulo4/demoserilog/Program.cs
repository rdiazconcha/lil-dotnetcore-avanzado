using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace demoserilog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog((context, configuration) => {
                    configuration.WriteTo.Console();
                    configuration.WriteTo.File("log.txt", Serilog.Events.LogEventLevel.Information);
                    configuration.WriteTo.MSSqlServer(Literals.ConnectionString, "Log", autoCreateSqlTable:true);
                    configuration.WriteTo.ApplicationInsights(new TelemetryClient(){ InstrumentationKey = "ef46ae13-0626-47af-9081-9bf949b0df35"}, TelemetryConverter.Events);
                }, writeToProviders:true)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                });
    }
}
