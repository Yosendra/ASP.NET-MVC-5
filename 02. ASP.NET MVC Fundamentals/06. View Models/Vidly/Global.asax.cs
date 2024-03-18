using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* View Models
 * 
 * If we want to pass two or more unrelated models to the view. For example we want to pass
 * A movie with its customer, we can use ViewModel
 * 
 * ViewModel is a model specifically built for a view
 * It includes any data and rules specific to that view
 * 
 * Add Customer class under Models folder
 * 
 * We use Models folder purely for domain classes like Movie, Customer, etc
 * We put ViewModel in a seperete folder
 * Create a folder named ViewModels
 * Create ViewModel class under that folder named "RandomMovieVM"
 * 
 * In MoviesController, in Random() action, construct the ViewModel class
 * and pass it to the View() method
 * 
 * In Random.cshtml, bind the model type to RandomMovieVM instead of Movie
 * 
 * Look at:
 * • Customer.cs
 * • RandomMovieVM.cs
 * • MoviesController.cs -> Random()
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
