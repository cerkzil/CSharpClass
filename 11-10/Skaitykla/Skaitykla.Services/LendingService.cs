using Skaitykla.Domains;
using Skaitykla.EF;
using Skaitykla.Services.Interfaces;
using System;

namespace Skaitykla.Services
{
    public class LendingService : ILendingService
    {
        private readonly BookContext _db;
        private readonly IBookService _bookService;
        public LendingService(BookContext db, IBookService bookService)
        {
            _db = db;
            _bookService = bookService;
        }


        public LendingBook BorrowBook(int bookId, User user)
        {
            LendingBook lending = new LendingBook
            {
                Book = _bookService.GetBookById(bookId),
                User = user,
                From = DateTime.Now
            };

            _db.Lendings.Add(lending);
            _db.SaveChanges();

            return lending;
        }


        public int Kvadratu(int n)
        {
            return n * n;
        }

    }
}
