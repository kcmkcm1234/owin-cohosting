using System;
using System.Threading.Tasks;
using Api1;
using Api2;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CoHost.Startup))]

namespace CoHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/api1cohostroot", api1App =>
            {
                api1App.UseApi1();
            });
            app.Map("/api2cohostroot", api2App =>
            {
                api2App.UseApi2();
            });
        }
    }
}
