using Skaitykla.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skaitykla.Services.Interfaces
{
    public interface IBookService
    {
        List<Book> GetBooks();
        int CreateBook(Book book);
        Book GetBookById(int id);
    }
}
