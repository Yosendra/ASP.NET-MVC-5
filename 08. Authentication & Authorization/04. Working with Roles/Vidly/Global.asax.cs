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
 * We are going to make a new page for guest user for displaying Movie or Customer
 * rather than using the same view. Because if we keep using the same view, it will
 * take a lot of logic for conditioning render page, like not displaying delete button
 * redendering hyperlink, etc
 * 
 * Create ReadOnlyList.cshtml under Movies view folder
 * Rename Index.cshtml into List.chtml
 * 
 * In MoviesController.Index() render the page based on user.
 * 
 * Test: login as guest then access movies page, do the same login as admin
 * 
 * We still have security hole, when login as guest, we can still access the new movie form
 * we need add [authorize] attribute based on role in the action method we want to restrict
 * 
 * In MoviesController.New(), add [Authorize(Roles = "CanManageMovies")]
 * 
 * Test: Login as guest, access /movies/new page. You will be redirected to login page
 * 
 * If you want, we need to apply this also in Update, Delete, Edit
 * Also in movie api also
 * 
 * Next we want to refactor the magic string of role "CanManageMovies"
 * Create a static class "RoleName" under Models folder
 * Refactor [Authorize(Roles = "CanManageMovies")] into [Authorize(Roles = RoleName.CanManageMovies)] 
 * 
 * Look at:
 * • ReadOnlyList.cshtml
 * • List.cshtml
 * • MoviesController.cs
 * • RoleName.cs
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
