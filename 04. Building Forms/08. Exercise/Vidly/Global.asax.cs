using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Excercise
 * 1. Add Edit Movie form
 * 
 * 
 * Look at:
 * • 
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
