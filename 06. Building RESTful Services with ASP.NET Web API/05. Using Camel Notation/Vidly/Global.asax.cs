using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using AutoMapper;
using Vidly.App_Start;

/* Using Camel Notation
 * 
 * Before, the return json from Web API is styled in PascalCase.
 * We want it to presented in camelCase since it is a javscript syntax.
 * We can configure it in WebApiConfig.cs
 * 
 * Run, go to the endpoint for querying customer in Web API
 * 
 * Look at:
 * • WebApiConfig.cs
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
