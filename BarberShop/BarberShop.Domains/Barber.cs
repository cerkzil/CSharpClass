using System;

namespace BarberShop.Domains
{
    public class Barber : Person
    {
        public Barber()
        {
            Id = Guid.NewGuid();
        }
    }
}