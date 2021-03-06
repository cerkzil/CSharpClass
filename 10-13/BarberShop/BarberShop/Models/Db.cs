﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarberShop.Domains;

namespace BarberShop.Models
{
    public static class Db
    {
        public static List<Booking> GetBookings()
        {
            Barber Tanaka = new Barber() { Name = "Tanaka", Surname = "Leafy", Age = 24, Gender = GenderOptions.male };
            Barber Haley = new Barber() { Name = "Haley", Surname = "Sarahs", Age = 21, Gender = GenderOptions.female };
            Barber Dylan = new Barber() { Name = "Dylan", Surname = "Ether", Age = 23, Gender = GenderOptions.male };
            Barber Milly = new Barber() { Name = "Milly", Surname = "Tompson", Age = 21, Gender = GenderOptions.other };

            List<Booking> bookings = new List<Booking>()
        {
                new Booking(){Barber = Tanaka, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now},
                new Booking(){Barber = Haley, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now},
                new Booking(){Barber = Dylan, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now.AddDays(-1)},
                new Booking(){Barber = Milly, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now.AddDays(-2)},
        };
            return bookings;
        }
    }
}
