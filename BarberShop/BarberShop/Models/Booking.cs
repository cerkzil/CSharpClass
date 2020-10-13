using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using BarberShop.Domains;
using System.Threading.Tasks;

namespace BarberShop.Models
{
    public class Booking
    {
        public Booking()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Barber Barber { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public DateTime AvailableTime { get; set; }
        public Client Client { get; set; }
    }
}
