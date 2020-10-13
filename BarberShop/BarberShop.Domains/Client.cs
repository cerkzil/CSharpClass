using System;

namespace BarberShop.Domains
{
    public class Client : Person
    {
        public Client()
        {
            Id = Guid.NewGuid();
        }
    }
}