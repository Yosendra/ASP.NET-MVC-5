using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Code-first Migrations
 * 
 * Install package EntityFramework via Nuget Package Manager
 * Right-click on Vidly project, choose Manage NuGet Packages
 * 
 * Install these packages in order to be able use Identity:
 * • Microsoft.AspNet.Identity.EntityFramework
 * • Microsoft.AspNet.Identity.Core
 * • Microsoft.AspNet.Identity.OWIN
 * Detail: https://learn.microsoft.com/en-us/aspnet/identity/overview/getting-started/introduction-to-aspnet-identity
 * 
 * Add ApplicationUser.cs (inherit from IdentityUser) under folder Models
 * Add ApplicationDbContext.cs (inherit from IdentityDbContext<ApplicationUser>) under folder Models
 * 
 * Define the connection string in web.config
 * 
 * For the first time, we need to enable migration in our project by inputting this command in Package Manager Console
 * Command: 
 *  enable-migration
 *  add-migration InitialModel 
 *     [or]
 *  add-migration InitialModel -force 
 *  (if there is existing migration file with same name)
 * 
 * After adding migration, persist it by inputing this command in Package Manager Console:
 *  update-database
 * 
 * Look at:
 * • ApplicationUser.cs
 * • ApplicationDbContext.cs
 * • Web.config
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
