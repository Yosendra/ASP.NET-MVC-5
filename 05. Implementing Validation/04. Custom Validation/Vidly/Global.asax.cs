using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Custom Validation
 * 
 * We are going to create our custom data annotation
 * The rule is user must be over than 18 years to be a member beside "Pay as You Go" category 
 * 
 * Create a custom annotation class "Min18YearsIfAMember" under Models folder
 * In Customer class, use our custom annotation class
 * 
 * Add validation message in CustomerForm for BirthDate input
 * 
 * Look at:
 * • Min18YearsIfAMember.cs
 * • Customer.cs
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
