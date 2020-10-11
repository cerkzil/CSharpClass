using System;

namespace BarberShop.Models
{
    public class Client : Person
    {
        public Client()
        {
            Id = Guid.NewGuid();
        }
    }
}