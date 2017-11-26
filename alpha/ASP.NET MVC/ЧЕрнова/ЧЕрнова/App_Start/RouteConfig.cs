using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ЧЕрнова
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.LowercaseUrls = true;

            routes.MapRoute(
                name: "Date",
                url: "{controller}/{action}/{year}/{month}/{date}",
                defaults: new { controller = "Home", action = "Index", year = 1991, month = 25, date = 12 },
                constraints: new {year = @"\d{4}", month=@"\d{2}", date=@"\d{2}"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{x}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "ActionOnly",
               url: "{controller}/{action}",
               defaults: new { controller = "Home", action = "Index" }
           );

            routes.MapRoute(
               name: "Empty",
               url: "",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );


        }
    }
}
