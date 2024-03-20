using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using AutoMapper;
using Vidly.App_Start;

/* Exercise
 * 
 * We are going to create Web API for Movies
 * 
 * Create MovieDto under Dtos folder
 * Register new profile for Movie in MappingProfile for AutoMapper
 * Implmenting endpoint for CRUD operation for Movies Web API
 * 
 * Look at:
 * • MovieDto.cs
 * • MappingProfile.cs
 * • MoviesController.cs (API)
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
