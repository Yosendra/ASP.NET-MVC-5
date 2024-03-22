using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Rental
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public DateTime RentedDate { get; set; }

        public DateTime? ReturnedDate { get; set; }
    }
}