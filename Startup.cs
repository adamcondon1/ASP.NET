using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectAdam.Startup))]
namespace ProjectAdam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
