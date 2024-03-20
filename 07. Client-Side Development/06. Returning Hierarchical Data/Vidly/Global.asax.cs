using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using AutoMapper;
using Vidly.App_Start;

/* Returning Hierarchical Data
 * 
 * Create MembershipTypeDto
 * Add new MembershipTypeDto type property in CustomerDto
 * 
 * MappingProfile, configure how to mapping this MembershipTypeDto in CustomerDto
 * 
 * In CustomersController.Index() we need to eager-load customer along with MembershipType
 * 
 * Look at:
 * • MembershipTypeDto.cs
 * • CustomerDto.cs
 * • MappingProfile.cs
 * • CustomersController.cs
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
