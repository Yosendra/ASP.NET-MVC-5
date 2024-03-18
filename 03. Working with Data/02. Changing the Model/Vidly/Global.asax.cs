using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Changing the Model
 * 
 * We will introduce new property in Customer model by adding these properties
 * • IsSubscribedToNewsletter
 * • MembershipType
 * (This is count as adding business rule to our model)
 * 
 * Our Rules
 * 
 * Membership               Sign Up Fee               Discount
 *  Pay as You Go            Free                      0%
 *  Monthly                  $30                       10%
 *  Quarterly                $90                       15%
 *  Annual                   $300                      20%
 * 
 * Customer (1) ==> (1) Membership type (SignUpFee, Duration, DiscountRate)
 * (Each customer should have one and only one membership type)
 * 
 * Bit by bit adding migration. First we only add IsSubscribedToNewsletter property in customer first
 * Then continue to the add migration.
 *  Add-Migration Add_IsSubscribedToNewsletter_column_in_Customer
 *  Update-Database
 * 
 * Add new class named "MembershipType" under Models folder
 * Associate the MembershipType to Customer
 *  Add-Migration Add_MembershipType
 *  Update-Database
 * 
 * Look at:
 * • Customer.cs
 * • MembershipType.cs
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
