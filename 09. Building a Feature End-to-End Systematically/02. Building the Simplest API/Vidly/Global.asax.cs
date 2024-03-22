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
 * Implement the API endpoint "POST /api/rentals"
 * 
 * Do optimization by adding new column "NumberAvailable" in Movie class
 * Then add a migration, append script for updating the its value also
 * Then update database
 * 
 * Add "movie.NumberAvailable--" inside foreach statement in RentalsController.CreateRental()
 * 
 * Look at:
 * • RentalsController.cs
 * • Movie.cs
 * • 202403221229253_Add_NumberAvailable_Column_in_Movies.cs
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
