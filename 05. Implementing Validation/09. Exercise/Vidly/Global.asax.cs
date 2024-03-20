using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Exercise
 * 
 * Do the same validation now in MovieForm.cshtml
 * 
 * Look at:
 * • MovieFormVM.cs
 * • MovieForm.cshtml
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
