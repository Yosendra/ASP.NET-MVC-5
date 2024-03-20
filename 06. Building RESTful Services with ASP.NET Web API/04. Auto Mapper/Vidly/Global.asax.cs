using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using AutoMapper;
using Vidly.App_Start;

/* Auto Mapper
 * 
 * Install package AutoMapper (4.1)
 * Make sure the same version
 * 
 * After installing we need to create mapping profile to determine
 * how object of different types can be mapped to each other
 * 
 * Under App_Start folder, create class "MappingProfile"
 * Configure the mapping profile
 * 
 * In Global.asax.cs, initialize the automapper
 * 
 * Now in CustomersController, we can change every type Customer into CustomerDto
 * 
 * Look at:
 * • MappingProfile.cs
 * • Global.asax.cs
 * • CustomersController.cs
*/

namespace Vidly
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());     // initialize the automapper
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
