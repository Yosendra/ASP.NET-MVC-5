using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Exercise 3 - Display the list of movies and their details
 * 1. Add Genres table
 * 2. Populate Genre table using migration
 * 3. Add column ReleaseDate, AddedDate, Stock, GenresId in Movie
 * 
 * Look at:
 * • Genre.cs
 * • ApplicationDbContext.cs
 * • 202403190224271_Add_Genres_table.cs
 * • 202403190226115_Populate_Genres_Table.cs
 * • Movie.cs
 * • 202403190254331_Add_ReleaseDate_AddedDate_NumberStock_GenreId_Column_in_Movies.cs
 * • MoviesController.cs
 * • Movies -> Index.cshtml, Details.cshtml
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
