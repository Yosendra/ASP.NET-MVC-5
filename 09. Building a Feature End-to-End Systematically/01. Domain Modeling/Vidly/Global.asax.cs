using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using Vidly.App_Start;

/* Add the ability to record rentals
 * 
 * Password: 
 *   guest@mailinator.com (Guest#123)
 *   admin@mailinator.com (Admin#123)
 * 
 * We want to extend our app. The customers are able to rent movies.
 * Before starting to code, we need to understand how the use case works.
 * In real experience, we need to talk to our clients or whoever we're building
 * this application for, and ask them questiions to better understand this use case.
 * 
 * Example: one of the use case is customer is able to rent a movie. The steps are 
 *          the customer come to the counter, give the movie to the staff member,
 *          the staff member identifies the customer by looking them up in the application.
 *          Then add each movie in the list of movies to customer is going to rent.
 *          That's the end of the transaction.
 *          
 * To implement the code, we can start either from backend or frontend.
 * But it is more preferebly to start from backend, because we don't get distracted with
 * complexity of the interface which can leak to the backend design.
 * We can focus only on the input and output of the application.
 * 
 * Based on the use case above we got:
 * Input -> Customer and Movies
 * Output -> None
 * 
 * On the backend we need to decide if we are using MVC controller or API controller
 * It is up to the programmer to decide. It depends on what you want to return 
 * to the client once the client submit a form. If you want to return a markup,
 * then choose MVC controller, if you want to return data only, then choose API controller
 * In this case we choose API controller.
 * 
 * =========== Time to code ===========
 * 
 * Create API controller named "RentalsController"
 * Create Dto class named "RentalDto"
 * 
 * Currently our domain class not supporting for rental.
 * So we need to add rental to our model.
 * 
 * We use UML diagram as a tool to understanding our model.
 * It help us to give a picture how our model relate to the other.
 *         
 *             rents
 *              ==> 
 * Cusotmer (*)     (*) Movie           (many-to-many relationship)
 *              <==
 *          can be rented
 *         
 * The association itself need attributes.
 * Because we want to record when movie is rented, and when the movie is returned
 * So we will create a class for this:
 *   Rental
 *     RentedDate
 *     ReturnedDate
 * In UML, when an association requires attribute we use what we call an
 * Association class. Rental is an association class.
 * 
 * Create Rental class for domain class
 * Add new property Rental in ApplcationDbContext
 * Create a migration, then update the database
 * 
 * Look at:
 * • RentalsController.cs
 * • RentalDto.cs
 * • Rental.cs
 * • ApplcationDbContext.cs
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
