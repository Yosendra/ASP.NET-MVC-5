using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Overriding Conventions
 * 
 * We want to change the type of Name column in Customers table.
 * It is nvarchar(max) and nullable, we want to change it not-nullable and max length to 255
 * using data annotation approach.
 * (Another method is using FluentAPI)
 * 
 * Give constraint attribute for Name property in Customer class
 *  Add-Migration ApplyAnnotationToCustomerName
 *  Update-Database
 * 
 * Now observe the Name column in Customer table
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
