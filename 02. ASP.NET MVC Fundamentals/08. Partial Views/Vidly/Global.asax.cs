using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Partial Views
 * 
 * At _Layout.cshtml, we can see a function invocation @RenderBody()
 * what we put in our views will be placed here when the view is rendered.
 * 
 * Partial view is like your small view that we can reuse on different views, but partial views are
 * not necessarily we're reusing markup. Sometimes we can use them to break down a large view into
 * smaller more maintainable partial views.
 * 
 * Create partial view for navigation bar under Views/Shared folder named "_NavBar.cshtml"
 * By convention, partial view always prefixed with underscore (_)
 * Put the view markup for navigation bar here
 * 
 * At _Layout.cshtml, we render the partial view that have seperated from the layout using Html.Partial() method
 * 
 * Look at:
 * • Random.cshtml
 * • _NavBar.cshtml
 * • _Layout.cshtml
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
