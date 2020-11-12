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

        public async Task<IEnumerable<Author>> GetAuthorsAsync()
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
    }
}
