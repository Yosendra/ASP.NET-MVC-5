using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Refactoring Magic Numbers
 * 
 * In MembershipType we are going to add static property to give the meaning of MembershipType
 * 
 * Look at:
 * • Min18YearsIfAMember.cs
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
