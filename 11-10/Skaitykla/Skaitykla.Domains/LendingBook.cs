using System;
using System.Collections.Generic;
using System.Text;

namespace Skaitykla.Domains
{
    public class LendingBook
    {
        public Guid Id { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

    }
}
