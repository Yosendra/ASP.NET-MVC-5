using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* ActionResult
 * 
 * Notice most of the action methods return type is "ActionResult"
 * This class is the base class for all action result in ASP.NET MVC
 * Dependending on what an action does, it would return an instance of one of the classes that derive from ActionResult
 * Statement "return View()" in Controller, View() is a helper method derived from Controller class
 * This method allows us to create ViewResult instance
 * 
 * So why not changing the action method return type to ViewResult?
 * It's because sometime it's possible that an action may have different execution paths then return different action result
 * In that case we need to set the return type of the action into ActionResult so we can return any of it subtypes
 * 
 * Kind of Action Result
 * 
 * Type                                 Helper Method from Controller
 * 
 * ViewResult                           View()
 * PartialViewResult                    PartialView()
 * ContentResult                        Content()
 * RedirectResult                       Redirect()
 * RedirectToRouteResult                RedirectToAction()
 * JsonResult                           Json()
 * FileResult                           File()
 * HttpNotFoundResult                   HttpNotFound()
 * EmptyResult                          
 * 
 * Test : go to /movie/random endpoint
 * 
 * Look at:
 * • MovieController
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
