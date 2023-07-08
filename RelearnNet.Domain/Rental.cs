using System.ComponentModel.DataAnnotations;

namespace RelearnNet.Domain
{
    public class Rental
    {
        [Key]
        public Guid RentailId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal TotalCost { get; set; }

        //One to Many Relationship
        public ICollection<Member> Members { get; set; }

        //Many to Many Relationship
        public ICollection<MovieRental> MovieRentals { get; set; }
    }
}