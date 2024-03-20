using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormVM
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
        public string Title
        {
            get => Movie != null && Movie.Id != 0 
                ? "Edit Movie"
                : "New Movie";
        }
    }
}