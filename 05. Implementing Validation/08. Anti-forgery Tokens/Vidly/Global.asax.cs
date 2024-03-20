using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Anti-forgery Tokens
 * 
 * CSRF => Cross-Site Request Forgery
 * 
 * Use @Html.AntiForgeryToken() inside the form in CustomerForm.cshtml
 * Use [ValidateAntiForgeryToken] attribute at CustomersController.Save()
 * 
 * Look at:
 * • CustomerForm.cshtml
 * • CustomersController.cs
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
