using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Model Binding
 * 
 * We are adding a submit button in new customer form
 * Adding Create() action method in CustomersController
 * 
 * Look at:
 * • CustomersController -> Create(), New.cshtml
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
