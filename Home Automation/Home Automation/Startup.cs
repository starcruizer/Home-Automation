using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Home_Automation.Startup))]
namespace Home_Automation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
