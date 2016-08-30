using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bartender
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //Route changed to reflect the name of the "MenuController" instead of the default, "HomeController"
                defaults: new { controller = "Menu", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
