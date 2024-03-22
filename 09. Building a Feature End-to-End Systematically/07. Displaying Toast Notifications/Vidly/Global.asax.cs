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
 * Implement jquery plugin toastr for notification
 * Install package "toastr"
 * 
 * Register the toastr stylesheet "~/Content/toastr.css" to the bundle in BundleConfig
 * Register the toastr script "~/Scripts/toastr.js" to the bundle in BundleConfig
 * 
 * In rental form New.cshtml, at .done(), write the toastr notification for success
 * In rental form New.cshtml, at .fail(), write the toastr notification for failure
 * 
 * Look at:
 * • BundleConfig.cs
 * • Rental -> New.cshtml
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
