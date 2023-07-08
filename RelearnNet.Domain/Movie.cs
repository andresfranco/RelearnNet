using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelearnNet.Domain
{
    public class Movie
    {
        [Key]
        public Guid MovieId { get; set; }
        public string MovieName { get; set; }=String.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }

        //Many to Many Relationship
        public ICollection<MovieRental>? MovieRentals { get; set; }
    }
}
