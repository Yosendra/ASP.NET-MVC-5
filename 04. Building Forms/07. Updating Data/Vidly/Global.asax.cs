using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Updating Data
 * 
 * In CustomerForm.cshtml we change the targer url of the form to Customers/Save
 * We are going to use this target link to both for adding customer and edit customer
 * depending the customer Id sended or not
 * 
 * Look at:
 * • CustomerForm.cshtml
 * • CustomersController -> Save()
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
