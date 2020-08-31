using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartplace.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set;}
    }

    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
