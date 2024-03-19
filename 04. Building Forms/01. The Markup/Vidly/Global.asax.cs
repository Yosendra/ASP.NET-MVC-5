using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* The Markup
 * 
 * We are going to create a form for adding customer
 * Create action method for opening add customer in CustomersController
 * 
 * Look at:
 * • CustomersController.cs -> New(), New.cshtml
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
