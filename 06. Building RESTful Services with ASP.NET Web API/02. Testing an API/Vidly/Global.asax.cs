using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;

/* Testing an API
 * 
 * Testing the API through Postman
 * Run the application, in postman test the endpoints that we have in our API
 * 
 * GET  http://localhost:59744/api/customers
 * GET  http://localhost:59744/api/customers/1
 * POST http://localhost:59744/api/customers
 * 
 * Look at:
 * • CustomersController.cs (API)
*/

namespace Vidly
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
