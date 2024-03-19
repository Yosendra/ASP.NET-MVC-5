using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Data Annotations
 * • [Required]
 * • [StringLength(255)]
 * • [Range(1, 10)]
 * • [Compare("OtherProperty")]
 * • [Phone]
 * • [EmailAddress]
 * • [Url]
 * • [RegularExpression("...")]
 * • etc
 * 
 * These are built-in data annotation by ASP.NET Web Framework
 * They are have their own default validation message, but we can override it
 * 
 * We override the error message for [Required] attribute in Name property of Customer
 * 
 * Look at:
 * • Customer.cs
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
