using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Mvc.Routing.Constraints;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();

            routes.MapRoute("ChromeRoute", "{*catchall}", 
                new { controller = "Customer", action = "List" }, 
                new { customConstraint = new UserAgentConstraint("Firefox") });

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new { controller = "^H.*|^C.*|^A*", action = "^Index$|^CustomVariable$|^List$",
                      httpMethod = new HttpMethodConstraint("GET"),
                      id = new CompoundRouteConstraint(new IRouteConstraint[] {
                           new AlphaRouteConstraint(),
                           new MinLengthRouteConstraint(6)
                      }) },
                new[] { "UrlsAndRoutes.Controllers" });
        }
    }
}