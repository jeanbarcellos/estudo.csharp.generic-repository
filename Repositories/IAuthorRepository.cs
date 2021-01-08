using System.Threading.Tasks;
using GenericRepository.Models;

namespace GenericRepository.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task<Author> GetByName(string firstName);
    }
}