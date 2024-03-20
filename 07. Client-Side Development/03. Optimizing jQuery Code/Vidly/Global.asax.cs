using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using AutoMapper;
using Vidly.App_Start;

/* Optimizing jQuery Code
 * 
 * At Index.cshtml (Customer) at this syntax
 *      $("#customers .js-delete").on("click", function () {
 *      
 * If there are 20 customers, each customer will have delete button, for each button we will have a seperate handler
 * button in memory. The more customer, the memory is consumed.
 * We change the selector become like this
 *      $("#customers").on("click", ".js-delete", function () {
 *      
 * The hook will be only one (table#customer), then it will filter element which has class .js-delete, then execute the callback
 * 
 * Look at:
 * • Customers -> Index.cshtml
*/

namespace Vidly
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());     // initialize the automapper
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
