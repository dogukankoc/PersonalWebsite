using Microsoft.EntityFrameworkCore;
using PersonalWebsiteAPI.Domain.Entities;

namespace PersonalWebsiteAPI.Persistence.Context
{
    public class PersonalWebsiteAPIDbContext : DbContext
    {
        public PersonalWebsiteAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}

