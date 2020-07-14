using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(p2020.WebUI.Startup))]
namespace p2020.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
