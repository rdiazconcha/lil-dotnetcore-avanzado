using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace workerservice
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder().Build().Run();
        }

        static IHostBuilder CreateHostBuilder(){
            var builder = Host.CreateDefaultBuilder()
            .UseWindowsService()
            .ConfigureServices((ctx, services) => {
                services.AddHostedService<Worker>();
            });
            
            return builder;
        }
    }
}
