using System.ComponentModel.DataAnnotations;

namespace RelearnNet.Domain
{
    public class MovieRental
    {
        [Key]
        public Guid RentalId { get; set; }
        [Key]
        public Guid MovieId { get; set; }

    }
}