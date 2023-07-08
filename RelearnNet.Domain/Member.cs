using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelearnNet.Domain
{
    public class Member
    {
        [Key]
        public  Guid MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  string Email { get; set; }
        public Guid RentalId { get; set; }
        public Rental Rental { get; set; }
    }
}
