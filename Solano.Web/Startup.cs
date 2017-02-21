using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Solano.Web.Startup))]
namespace Solano.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
