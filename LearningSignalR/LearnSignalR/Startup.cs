using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnSignalR.Startup))]
namespace LearnSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
