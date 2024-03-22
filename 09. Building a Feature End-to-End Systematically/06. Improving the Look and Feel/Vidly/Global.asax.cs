using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using Vidly.App_Start;

/* Password:
 *   guest@mailinator.com (Guest#123)
 *   admin@mailinator.com (Admin#123)
 * 
 * Implement typeahead for the movies input
 * Applying filter on GetMovies, GetCustomers on API
 * Some fix styling on New.cshtml for rental
 * 
 * Notice at e.preventDefault in New.cshtml
 * if we do not include this, the form will submit normally
 * We don't want this because we are using ajax
 * 
 * Add jquery logic for submit in rental form
 * $("#rental").submit()
 * 
 * Look at:
 * • Rental -> New.cshtml
 * • MoviesController.cs -> GetMovies
 * • CustomersController.cs -> GetCustomers
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
