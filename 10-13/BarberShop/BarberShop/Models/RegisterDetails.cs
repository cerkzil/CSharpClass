using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BarberShop.Models
{
    public class RegisterDetails
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool Confirmed { get; set; }
        public int BookingId { get; set; }
    }
}
