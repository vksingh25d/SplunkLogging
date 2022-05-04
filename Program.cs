using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System;
using Splunk.Logging;
using Newtonsoft.Json.Linq;

namespace Splunk_Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ContainerConfiguration.Configure();
            var logger = serviceProvider.GetService<ILogger<Program>>();
            logger.LogInformation("Test splunk log : " + DateTime.Now + " , Hello Vikas ");
        }
    }
}
