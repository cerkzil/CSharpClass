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
            _db.SaveChanges();
            return book.Id;
        }

        public Book GetBookById(int id)
        {
            return _db.Books.Find(id);
        }

        public List<Book> GetBooks()
        {
            return _db.Books.Include(b => b.Author).ToList();
        }

        public List<Book> GetAvailableBooks()
        {
            //todo implement available books
            return _db.Books.Include(b => b.Author).ToList();
        }
    }
}