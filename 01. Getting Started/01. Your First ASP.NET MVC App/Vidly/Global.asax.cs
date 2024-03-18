using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Install project template for legacy version of ASP.NET 5 MVC
 * Go to Visual Studio Installer in Start Menu
 *  -> VS Community 2022 (Modify) 
 *  -> Individual Components 
 *  -> tick the ".NET Framework project and items templates", then install
 *  
 * Generate the project, choose ASP.NET Web Application (Not the core version, this is old version)
 * 
 * Generated folders and files explanation:
 * • App_Data     : the place database is stored
 * • App_Start    : includes few classes that are called when the application is started
 *                  RouteConfig.cs -> the configuration of routing rules
 *     
 * • Content      : the place static files are stored, CSS files, images, and any other client side assetes
 * • Controllers  : the place controller files
 * • Models       : domain classes stored here
 * • Scripts      : the place javascript files is stored
 * • Views        : the place for View files is stored
 *                  Contains folder named based on controller's name, except "Shared"
 * 
 * • favicon.ico  : icon of the web application displayed in the browser
 * • Global.asax  : one of the traditional files that has been in ASP.NET for a long time.
 *                  A class that provides hooks for various events in the application lifecycle
 * 
 * • packages.config : used by Nuget Package Manager to install package
 * • Web.config      : XML file that contains configuration for application
 *                     Mostly you will will work on this two section: 
 *                     connectionStrings -> the place to define the database's connection string
 *                     appSettings -> the place for configuration setting we want to define and custom
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
