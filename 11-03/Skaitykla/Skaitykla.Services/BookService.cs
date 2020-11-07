using Microsoft.EntityFrameworkCore;
using Skaitykla.Domains;
using Skaitykla.EF;
using Skaitykla.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Skaitykla.Services
{
    public class BookService : IBookService
    {
        private readonly BookContext _db;

        public BookService(BookContext db)
        {
            _db = db;
        }

        public int CreateBook(Book book)
        {
            _db.Books.Add(book);
            return _db.SaveChanges();
        }

        public List<Book> GetBooks()
        {
            return _db.Books.Include(b => b.Author).ToList();
        }
    }
}