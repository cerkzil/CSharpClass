using System;
using System.Collections.Generic;
using System.Text;
using Skaitykla.Domains;
using Microsoft.EntityFrameworkCore;

namespace Skaitykla.EF
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=KAB215-05\\" +
                                       "SQLEXPRESS\\\\" +
                                       "MSSQLLocalDB;" +
                                       "Database=_KITM;" +
                                       "Trusted_Connection=True;" +
                                       "MultipleActiveResultSets=true");
        }
    }
}
