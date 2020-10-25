using System;

namespace Skaitykla.Domains
{
    public class Author
    {
        public Author(string name, string surname)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
        }


        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}