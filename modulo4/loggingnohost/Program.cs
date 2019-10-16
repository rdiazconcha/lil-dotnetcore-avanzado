using System;
using  Microsoft.Extensions.Logging;

namespace loggingnohost
{
    class Program
    {
        static void Main(string[] args)
        {
            using var loggerFactory =LoggerFactory.Create(builder => {
                builder.SetMinimumLevel(LogLevel.Debug);
                builder.AddConsole();
            });
            
            var logger = loggerFactory.CreateLogger<Program>();
            logger.Log(LogLevel.Debug, "Hola Debug");
            logger.Log(LogLevel.Information, "Hola mundo");
            logger.Log(LogLevel.Warning, "Hola Warning");
        }
    }
}