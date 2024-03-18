using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Action Parameters
 * 
 * Before, ActionResult is the output for action method.
 * Now, action parameters is the input for the action.
 * 
 * Parameter Binding
 * Request => MVC Framework => Action
 * 
 * Parameter Source
 * • In the url:            /movies/edit/[1]
 * • In the query string:   /movies/edit?[id=1]
 * • In the form data:      id=1
 * 
 * Test : /movie/edit/4
 *        /movie/edit?id=4
 * 
 * Create Index() action method in MovieController, implement default parameter value
 * 
 * Test : /movie
 *        /movie?pageIndex=12&sortBy=Age
 *        
 * Right now we cannot embed these two parameters pageIndex & sortBy in the url
 * It will be solved in custom route
 * 
 * Look at:
 * • MovieController => Edit(), Index()
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
