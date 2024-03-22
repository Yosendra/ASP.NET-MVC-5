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
 * We are going to create Rental Form using AJAX
 * Add new MVC controller "RentalsController"
 * Rename Index() to New(). We are going to use this to return the form to the client
 * Add the New.cshtml as its view
 * 
 * We are not going to use @Html.BeginForm() because it will create a traditional form
 * Instead we are using raw html
 * 
 * Add the menu for rentals in _NavBar.cshtml
 * Give hyperlink to direct the form of Rental
 * 
 * Look at:
 * • RentalsController.cs -> New(), New.cshtml
 * • _NavBar.cshtml
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
