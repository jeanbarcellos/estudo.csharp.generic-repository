using Microsoft.EntityFrameworkCore;
using GenericRepository.Models;

namespace GenericRepository.Repositories
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }
    }
}