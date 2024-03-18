using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Convention-based Routing
 * 
 * Create a custom route in RouteConfig for "movies/released/{year}/{month}" endpoint
 * Add action method ByReleaseDate() in MovieController
 * 
 * Test : movies/released/2019/11
 * 
 * Look at:
 * • RouteConfig.cs
 * • MovieController.cs -> ByReleaseDate()
*/

namespace Vidly
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
