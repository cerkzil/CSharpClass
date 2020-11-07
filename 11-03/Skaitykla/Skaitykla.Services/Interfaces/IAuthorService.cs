using Skaitykla.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Skaitykla.Services.Interfaces
{
    public interface IAuthorService
    {
        IEnumerable<Author> GetAuthors();
        Task<int> CreateAuthorAsync(string name, string surname);
        Task<int> DeleteAuthorAsync(Guid id);
        Author GetAuthorById(Guid id);
    }
}
