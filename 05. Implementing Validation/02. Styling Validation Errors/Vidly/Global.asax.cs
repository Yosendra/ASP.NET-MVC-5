using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Styling Validation Errors
 * 
 * Site.css is the place we put styling for our project
 * Add validation message for another input box in CustomerForm.cshtml
 * 
 * Look at:
 * • Site.css
 * • CustomerForm.cshtml
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
