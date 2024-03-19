using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Adding Validation
 * 
 * Constraint a property through attribute (data annotation)
 * In Customer, we use several attribute for constraint a few property
 * In CustomersController.Save() we try to get access to validation parameter result through ModelState property
 * If customer not valid, return the same form along with displaying validation message in the form
 * 
 * Add validation message in the form "CustomerForm" page
 * 
 * Look at:
 * • Customer.cs
 * • CustomersController.cs -> Save()
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
