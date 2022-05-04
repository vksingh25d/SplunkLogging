using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Common;
using NLog.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Splunk_Logging
{
    internal static class ContainerConfiguration
    {
        public static IServiceProvider Configure()
        {
            var serviceCollection = new ServiceCollection();

            var s = LogManager.LoadConfiguration("nLog.xml");

            serviceCollection.AddLogging(o =>
            {
                o.ClearProviders();
                o.AddNLog();
            }).Configure<LoggerFilterOptions>(c => c.MinLevel = Microsoft.Extensions.Logging.LogLevel.Trace);

            return serviceCollection.BuildServiceProvider();
        }
    }
}
