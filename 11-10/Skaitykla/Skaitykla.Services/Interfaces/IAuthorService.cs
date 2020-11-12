using Skaitykla.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Skaitykla.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAuthorsAsync();
        Task<int> CreateAuthorAsync(string name, string surname);
        Author GetAuthorById(Guid id);
    }
}
