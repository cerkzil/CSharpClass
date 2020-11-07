using Microsoft.EntityFrameworkCore;
using Skaitykla.Domains;
using Skaitykla.EF;
using Skaitykla.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skaitykla.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly BookContext _db;
        private readonly IBookService _bookService;
        public AuthorService(BookContext db, IBookService bookService)
        {
            _db = db;
            _bookService = bookService;
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _db.Authors.Include(x => x.WrittenBooks);
        }

        public Author GetAuthorById(Guid id)
        {
            return _db.Authors.Where(a => a.Id == id).FirstOrDefault();
        }

        public Task<int> CreateAuthorAsync(string name, string surname)
        {
            var newAuthor = new Author(name, surname);
            _db.Authors.Add(newAuthor);
            return _db.SaveChangesAsync();
        }
        public Task<int> DeleteAuthorAsync(Guid id)
        {
            var author = _db.Authors.Where(x => x.Id == id).Single();
            var books = _db.Books.Where(x => x.Author == author).ToList();
            foreach (Book item in books)
            {
                _db.Books.Remove(item);
            }
            _db.Authors.Remove(author);
            return _db.SaveChangesAsync();
        }
    }
}
