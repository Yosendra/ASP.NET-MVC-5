using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            //var movies = GetMovies();
            var movies = _context.Movies
                .Include(m => m.Genre)      // eager loading
                .ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            //var movies = GetMovies();

            //var movie = movies.SingleOrDefault(x => x.Id == id);
            var movie = _context.Movies
                .Include(m => m.Genre)      // eager loading
                .SingleOrDefault(x => x.Id == id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        // Not needed anymore, we use the data in database
        //private IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie { Id = 1, Name = "Shrek"},
        //        new Movie { Id = 2, Name = "Wall-e"},
        //    };
        //}

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}