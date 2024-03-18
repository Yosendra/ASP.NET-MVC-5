using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Attribute Routing
 * 
 * In order to use attribute routing, we need to enable it in RouteConfig.cs
 * 
 * We can use constraint in attribute route
 * There are min, max, minlength, maxlength, int, float, guid, etc
 * 
 * Look at:
 * • RouteConfig.cs
 * • MoviesController.cs
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
