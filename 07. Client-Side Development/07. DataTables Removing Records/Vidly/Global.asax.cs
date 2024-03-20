using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using AutoMapper;
using Vidly.App_Start;

/* DataTables Removing Records
 * 
 * Before there is a bug. When we delete a customer, then search the deleted customer.
 * We can still find it in the table.
 * To fix this we need to invoke API draw() of datatables.
 * Look at the implementation at Index.cshtml (Customers)
 * 
 * Look at:
 * • Customers -> Index.cshtml
*/

namespace Vidly
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
