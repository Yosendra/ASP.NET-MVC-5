using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // make sure this comes before the default route
            routes.MapRoute(
                name: "MoviesByReleaseDate",
                url: "movies/released/{year}/{month}",
                defaults: new { controller = "Movie", action = "ByReleaseDate" }, 
                constraints: new { year = @"\d{4}", month = @"\d{2}" }  // constraint for parameters with regex
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
