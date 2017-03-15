using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Infrastructure.Server.Initialization;
using Infrastructure.Shared.Initialization;

namespace Solano.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var initializationContext = InitializationContext.Create(ControllerBuilder.Current);
            Bootstrap.Start(initializationContext);
            
        }
    }
}
