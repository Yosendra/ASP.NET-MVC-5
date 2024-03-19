using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Querying Objects
 * 
 * We are going to get the customer data from database instead of using the hardcoded one in CustomerController
 * 
 * Override Dispose() method from Controller
 * Add logic for querying data through database using ApplicationDbContext
 * 
 * Add dummy data in Customers table for testing
 *  1, John Smith, false, 1
 *  2, Mary William, true, 2
 * 
 * Test: 
 * 
 * Look at:
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
