using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YH_Student
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
   Host.CreateDefaultBuilder(args)
     .UseServiceProviderFactory(new AutofacServiceProviderFactory()) //<--NOTE THIS
     .ConfigureWebHostDefaults(webBuilder =>
     {
         webBuilder
           .UseStartup<Startup>()
           .UseUrls("http://localhost:8081")
           .ConfigureLogging((hostingContext, builder) =>
           {
               builder.ClearProviders();
               builder.SetMinimumLevel(LogLevel.Trace);
               builder.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
               builder.AddConsole();
               builder.AddDebug();
           });
     });
    }
}
