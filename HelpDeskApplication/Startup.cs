using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelpDeskApplication.Startup))]
namespace HelpDeskApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
