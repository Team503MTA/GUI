using System.Web.Mvc;
using System.Web.Routing;

namespace Population
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { Controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "Population.Controllers" }
            );
        }
    }
}
