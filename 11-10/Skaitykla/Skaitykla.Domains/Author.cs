using System;
using System.Collections.Generic;

namespace Skaitykla.Domains
{
    public class Author
    {
        public Author(string name, string surname)
        {
            Name = name;
            Surname = surname;
            WrittenBooks = new List<Book>();
        }


        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        [System.ComponentModel.DisplayName("Written books")]
        public List<Book> WrittenBooks { get; set; }
    }
}