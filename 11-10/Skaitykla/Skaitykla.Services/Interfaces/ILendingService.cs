using Skaitykla.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skaitykla.Services.Interfaces
{
    public interface ILendingService
    {
        LendingBook BorrowBook(int bookId, User user);
        int Kvadratu(int n);
    }
}
