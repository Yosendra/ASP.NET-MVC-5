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
 * Implementing Client-Side Validation
 * At rental form, include the syntax for rendering jquery-validation script
 * @Scripts.Render("~/bundles/jqueryval")
 * 
 * Change the implementation from 
 *  $("#rental").submit() to $("#rental").validate()
 * 
 * Style for the validation message
 * 
 * There is still some bug, when typing incorrect customer
 * the validation message disappear. We have to force the form
 * to include the correct customer. Which is only customer
 * from typeahead display.
 * Use $.validator.addMethod() to implement the validation
 * 
 * Now implement the same for movie input.
 * The rule is user has to input at least one movie to be rented.
 * 
 * Take a look New.cshtml, many logic added for clearing the 
 * form state.
 * 
 * Look at:
 * • Rental -> New.cshtml
 * • Site.css
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
