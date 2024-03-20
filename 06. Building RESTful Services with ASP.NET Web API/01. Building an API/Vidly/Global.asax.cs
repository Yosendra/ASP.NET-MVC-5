using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;

/* Building an API
 * 
 * Create new folder named "Api" under Controllers folder.
 * Right click on it, add new controller for web api
 * Install the necessary packages in Nuget Package Manager
 * Read readme.txt which appears after generating api controller
 * 
 * Look at:
 * • WebApiConfig.cs
 * • Global.asax.cs
 * • CustomersController.cs (API)
*/

namespace Vidly
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
