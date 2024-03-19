using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Eager Loading
 * 
 * In Customer, currently we are displaying name only, what if we want to have another column DiscountRate available for each customer
 * Add to display DiscountRate column in customer table
 * 
 * Test: / (exception happen)
 * 
 * This caused by null reference of "customer.MembershipType.DiscountRate"
 * To solve this, we need to load the customers along with their MembershipType together.
 * This is called eager loading
 * 
 * Do eager loading for customers in CustomersController
 * 
 * Test: / (normal)
 * 
 * Look at:
 * • Customer -> Index.cshtml
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
