using System;

namespace BarberShop.Models
{
    public class Barber : Person
    {
        public Barber()
        {
            Id = Guid.NewGuid();
        }
    }
}