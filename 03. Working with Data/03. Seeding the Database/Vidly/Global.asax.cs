using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Seeding the Database
 * 
 * We are going to populate data for MembershipType table
 * The data should be consistent across different environments
 * Either in development database, production database, or testing database
 * All must have the same exact membership type 
 * 
 * In Package Manager Console
 *  Add-Migration PopulateMembershipTypes
 * 
 * In the generated migration file (202403190020130_PopulateMembershipTypes), 
 * we can populate the data for MembershipTypes table using Sql() function
 * After that:
 *  Update-Database
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
