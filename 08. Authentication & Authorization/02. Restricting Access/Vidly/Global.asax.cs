using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using Vidly.App_Start;

/* Restricting Access
 * 
 * Using [Authorize] attribute on action method, we can restrict user from accessing that action method
 * User must login to be able to access that action method
 * If user not is not authenticated, user will be redirected to login page.
 * 
 * we are going to apply the [Authorize] globally.
 * We put that in FilterConfig
 * 
 * we put [AllowAnonymous] attribute for HomeController
 * So guest user can still visit web without login
 * 
 * Test: run the application, compare your visit when accessing Home, About, Contact page and Movies, Customer, etc
 * 
 * Look at:
 * • FilterConfig.cs
 * • HomeController.cs
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
