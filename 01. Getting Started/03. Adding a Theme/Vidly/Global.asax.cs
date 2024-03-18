using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* This ASP.NET Web Application is using bootstrap as its frontend css framework.
 * So to replace this template we need to find bootstrap template.
 * Go to https://bootswatch.com/, under Themes, select Lumen
 * Under Lumen dropdown, download "bootstrap.css" file
 * Rename it into "bootstrap-lumen.css" to differentiate between the existing file
 * Place it in our project under Content folder.
 * 
 * Now we need to replace the reference to bootstrap with bootstrap-lumen
 * Under folder App_Start, go to BundleConfig.cs 
 * BundleConfig.cs is the place we define various bundles of client side assets
 * Bundle means to combine and compress multiple javascript or css files into a single file
 * This way we can reduce the number of HTTP requests required to get these assets when a page is loaded
 * Under "bundles.Add(new StyleBundle("~/Content/css").Include()", change the bootstrap.css to bootstrap-lumen.css
 * 
 * Test: run the application, check the themes is now different
 * 
 * Look at:
 * • bootstrap-lumen.css
 * • BundleConfig.cs
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
