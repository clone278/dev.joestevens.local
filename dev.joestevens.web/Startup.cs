using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dev.joestevens.web.Startup))]
namespace dev.joestevens.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
