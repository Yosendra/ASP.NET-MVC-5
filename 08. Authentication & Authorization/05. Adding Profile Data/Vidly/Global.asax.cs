using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using Vidly.App_Start;

/* Working with Roles
 * 
 * Password: 
 *   guest@mailinator.com (Guest#123)
 *   admin@mailinator.com (Admin#123)
 * 
 * We want to extend the user profile.
 * In register user we only provided with email and password input only
 * We will add driving license to the form
 * Start from the domain class, which is ApplicationUser class in IdentityModels.cs
 * 
 * Add DrivingLicense property in ApplicationUser class
 * Add migratiion for updating the model
 * 
 * Add the DrivingLicense property in RegisterViewModel class in AccountViewModels.cs
 * Add the DrivingLicense input on the Register.cshtml view 
 * 
 * In AccountController.Register() (POST), map the DrivingLicense property when constructing ApplicationUser object
 * 
 * Test : Register new user along with driving license, check the data for the new user in database, notice the DrivingLicense column
 * 
 * Look at:
 * • IdentityModels.cs
 * • 202403211804350_Add_DrivingLicense_to_ApplicationUser.cs
 * • AccountViewModels.cs
 * • Register.cshtml
 * • AccountController.cs -> Register() (POST)
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
