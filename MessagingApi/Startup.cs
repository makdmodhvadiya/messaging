using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(MessagingApi.Startup))]

namespace MessagingApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HubConfiguration() { EnableDetailedErrors = true, EnableJSONP = true };
            app.MapSignalR();
        }
    }
}
