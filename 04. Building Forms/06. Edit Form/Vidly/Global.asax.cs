using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Edit Form
 * 
 * We are going to create Edit Form for customer
 * Add action method Edit() in CustomerController
 * 
 * Rename NewCustomerVM into CustomerFormVM
 * Rename New.cshtml into CustomerForm.cshtml
 * 
 * Notice in the New() action method, we pass CustomerForm in the View()
 * because we have changing New.cshtml into CustomerForm.cshtml
 * 
 * We change the url of Customer hyperlink to direct to the Customer Form
 * 
 * Look at:
 * • CustomersController -> Edit(), Index.cshtml
 * • CustomerFormVM.cs
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
