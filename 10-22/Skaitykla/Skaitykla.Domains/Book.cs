using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;

namespace Skaitykla.Domains
{
    public class Book
    {

        public Book()
        {
            Id = new Random().Next(1000);
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }

    }
}
