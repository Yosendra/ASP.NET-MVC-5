using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Drop-down Lists
 * 
 * We are going to add dropdown-list of MembershipType in new customer form
 * First udpate the ApplicationDbContext, add DbSet<MembershipType> as property
 * 
 * Create a view model named "NewCustomerVM"
 * In CustomersController.New(), query the membership type
 * Pass the view model object to the view
 * 
 * In New.cshthml (Customers) implement the dropdown list of the Membership types
 * 
 * Look at:
 * • ApplicationDbContext.cs
 * • NewCustomerVM.cs
 * • CustomersController -> New(), New.cshtml
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
