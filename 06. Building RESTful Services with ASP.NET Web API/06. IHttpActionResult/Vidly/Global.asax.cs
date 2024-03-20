using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using AutoMapper;
using Vidly.App_Start;

/* IHttpActionResult
 * 
 * Prefer to use IHttpActionResult as the return type in Web API
 * It is same reason like ActionResult in MVC
 * 
 * Comment out the [Min18YearsIfAMember] attribute in CustomerDto
 * 
 * Look at:
 * • CustomersController.cs
 * • CustomerDto.cs
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
