using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace TerminalWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig2.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig2.RegisterRoutes(RouteTable.Routes);
            BundleConfig2.RegisterBundles(BundleTable.Bundles);
        }
    }
}
