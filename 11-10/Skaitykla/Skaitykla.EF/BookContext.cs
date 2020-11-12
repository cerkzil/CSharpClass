using Microsoft.EntityFrameworkCore;
using Skaitykla.Domains;

namespace Skaitykla.EF
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors{ get; set; }
        public DbSet<LendingBook> Lendings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BBFEDD6;" +
                                        "Database=coreDB;" +
                                        "Trusted_Connection=True;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Author>().HasMany(a=>a.WrittenBooks)
        //        .
        //        .OnDelete()
        //}
    }
}
