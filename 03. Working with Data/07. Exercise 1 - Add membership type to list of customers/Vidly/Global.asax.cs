using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Exercise 1 - Add membership type to list of customers
 * 1. Add Name to MembershipType
 * 2. Update the database
 * 3. Create another migration to update existing records
 * 4. Update the database
 * 
 * Id   Membership               Sign Up Fee               Discount
 *  1    Pay as You Go            Free                      0%
 *  2    Monthly                  $30                       10%
 *  3    Quarterly                $90                       15%
 *  4    Annual                   $300                      20%
 *  
 * Look at:
 * • MembershipType.cs
 * • 202403190135246_GivingNameToMembershipType.cs
 * • Customer -> Index.cshtml
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
