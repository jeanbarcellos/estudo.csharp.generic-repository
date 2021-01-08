using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GenericRepository.Modelos
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            LoadDefaultUsers();
        }

        public List<User> getUsers() => Users.Local.ToList<User>();

        private void LoadDefaultUsers()
        {
            Users.Add(new User { UserId = 100L, DateOfBirth = DateTime.Now, FirstName = "Tom" });
            Users.Add(new User { UserId = 200L, DateOfBirth = DateTime.Now, FirstName = "Arthur" });
        }

    }
}