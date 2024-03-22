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
 * To use autocomplete in the form, we need to install jquery plugin
 * named "Twitter.Typeahead" in Nuget Package Manager
 * 
 * Add the "~/Scripts/typeahead.bundle.js" into the bundle in BundleConfig
 * Copy the css for typehead because from the installation before it is not included the styleshee.
 * Go to "https://twitter.github.io/typeahead.js/examples/", the then copy the css from .typeahead to .tt-suggestion p
 * 
 * Add new css file under Content folder, name it "typehead.css"
 * then paste those css
 * 
 * Register typehead.css to the bundle in BundleConfig
 * 
 * Go back look at the typehead example website
 * Look next for copy the javascript to fetch remote data
 * In New.cshtml (Rentals), add section script, then paste the javascript code
 * we got from before there
 * 
 * (Issue: Autocomplete is not shown)
 * 
 * Look at:
 * • BundleConfig.cs
 * • typehead.css
 * • Rentals -> New.cshtml
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
