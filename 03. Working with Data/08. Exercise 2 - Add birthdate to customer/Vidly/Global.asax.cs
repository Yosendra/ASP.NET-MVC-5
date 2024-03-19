using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Exercise 2 - Add birthdate to customer
 * 1. Add nullable birthdate to Customers
 * 2. Give dummy data for birthdate
 * 3. Render the birthdate in customer detail page
 * 
 * Look at:
 * • Customer.cs
 * • CustomersController.cs (eager loading in ".Details()" action method)
 * • Customer -> Detail.cshtml
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
