using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Client-side Validation
 * 
 * We are going to enable client-side validation by using jquery-val bundle
 * Add a section script at most bottom of CustomerForm.cshtml
 * 
 * Notice: client-side validation only works on built-in data annotation.
 *         for our custom data annotation like "Min18YearsIfAMember",
 *         it only works on Server side, not supported in client-side.
 *         If you want, it needs some jquery code
 * 
 * Look at:
 * • CustomerForm.cshtml
 * • _Layout.cshtml
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
