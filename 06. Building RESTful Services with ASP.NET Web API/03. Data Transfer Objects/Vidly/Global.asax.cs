using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;

/* Data Transfer Objects
 * 
 * The problem we have in CustomersControllers is we still use Customer class (which is a domain class)
 * as the parameter for receiving data. If we keep this, the domain class will be polluted with unnecessary
 * property. So we need dedicated class for receiving the data. That is what we call DTO (Data Transfer Objects)
 * DTO is a plain data structure and is used to transfer data from client to server and vice versa.
 * 
 * Add new folder named "Dtos"
 * Under this folder create CustomerDto class
 * 
 * Look at:
 * • CustomerDto.cs
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
