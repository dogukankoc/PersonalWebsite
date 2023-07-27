using Microsoft.EntityFrameworkCore;
using PersonalWebsiteAPI.Domain.Entities;
using PersonalWebsiteAPI.Domain.Entities.Common;

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

        //Interceptor for CreatedDate and UpdatedDate properties
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.Now,
                    _ => DateTime.Now
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}

