using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace wednesday2
{
    public class Program
    {
        // Hey, this is just a console app! We can see it run as a console app.
        // this is how programs work - they have a console program running in the background.

        // old architecture used to run everything under the same giant monolithic webserver.
        //    but if something goes wrong... you have to bring that whole thing back up
        // newer architecture uses many many small console apps
        //    "microservices"
        //    one can crash/upgrade/recover without taking them all down - and very quickly.
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>(); // use startup! we have something called startup ^^
    }
}
