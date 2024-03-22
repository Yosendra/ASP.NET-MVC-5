using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using Vidly.App_Start;

/* OAuth (Open Authorization)
 * 
 * Password: 
 *   guest@mailinator.com (Guest#123)
 *   admin@mailinator.com (Admin#123)
 * 
 * 1. Register our application to facebook. Create a partnership. 
 *    Facebook will give us an API key. With this we communicate with Facebook under the hood.
 * 2. When a user login using his facebook in our application. Our application redirect him
 *    to facebook, along with our API key and secret, so facebook know the request comes
 *    from our application.
 * 3. Now the user has logged in facebook. In our application we don't care his facebook credentials are.
 *    Once he logs into facebook, facebook tells him that our application wants to access some basic
 *    information about that user.
 * 4. The user can authorize our application to access his information. Since we registered our application
 *    to facebook at the beginning, facebook know the address of our application, so it will redirect 
 *    user back to our application also pass an authorization token. This authorization token 
 *    tells our application that facebook successfully authenticate this user.
 * 5. Now on our application, we get this authorization token and send it back to facebook with our API key and secret
 *    It do this because a hacker may send a random authorization token to our app, so we need to verify that it is
 *    really came from facebook.
 * 6. After facebook admitting that authorization token, then facebook will give us access token.
 *    With this access token, we can access some parts of the user's profile the part we have permission to access.
 *    All of these low level details, we never have to manually implement them. They are all baked into the Identity.
 * 
 * Using Social Logins
 * • Enable SSL (for secure communication)
 * • Register our app with Facebook
 * 
 * Enable SSL -> open property window, choose our project, set Enable SSL to true
 * Copy the SSL url: https://localhost:44394/ (HTTPS)
 * Non SSL url: http://localhost:50522/ (HTTP)
 * 
 * Right click project, choose properties, choose web, override the project url with url above
 * Add filter in FilterConfig to require HTTPS. With this our application will no longer be available
 * on HTTP channel.
 * 
 * Register our application to facebook: https://developers.facebook.com/
 * Register the localhost domain, get appId and appSecret.
 * Assign these in Startup.Auth.cs at app.UseFacebookAuthentication()
 * 
 * (Not completed yet)
 * 
 * Look at:
 * • FilterConfig.cs
 * • Startup.Auth.cs
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
