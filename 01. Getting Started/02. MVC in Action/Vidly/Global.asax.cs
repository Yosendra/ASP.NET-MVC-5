using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Create a new model class named "Movie" in a folder named "Models"
 * This class is called POCO (Plain Old CLR Object), represents the state and behavior of our application in terms of problem domain
 * In this case it doesn't have any behavior or logic, it just has a couple of properties which we use for representing state.
 * 
 * Add an endpoint: movie/random
 * Add controller by right-click in Controller folder, add Controller, choose empty controller, name it "MovieController"
 * Rename existing action method "Index" into "Random"
 * Add View page for "movie/random" endpoint by right-click in View/Movie directory, and name it "Random"
 * 
 * Test: run the application, go to this endpoint "movie/random"
 * 
 * Look at:
 * • Movie.cs
 * • MovieController.cs
 * • Random.cshtml
*/

namespace Vidly
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
