using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieVM
    {
        public Movie Movie { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}