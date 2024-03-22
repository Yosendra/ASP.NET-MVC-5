using System;
using System.Linq;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateRental(RentalDto dto)
        {
            var customer = _context.Customers.Single(c => c.Id == dto.CustomerId);
            var movies = _context.Movies.Where(m => dto.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    CustomerId = customer.Id,
                    MovieId = movie.Id,
                    RentedDate = DateTime.Now,
                };
                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();
            return Ok();
        }
    }
}
