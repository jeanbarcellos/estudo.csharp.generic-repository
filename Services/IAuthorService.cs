using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GenericRepository.Models;

namespace GenericRepository.Services
{
    public interface IAuthorService
    {
        IEnumerable<Author> GetAllAuthors();
        Task<Author> GetAuthorByName(string firstName);
        void InsertAuthor(Author author);
        void UpdateAuthor(Author author);
        void DeleteAuthor(Guid id);
    }
}
