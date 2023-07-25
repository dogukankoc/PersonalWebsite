using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.IdentityModel.Protocols;
using PersonalWebsiteAPI.Persistence;
using PersonalWebsiteAPI.Persistence.Context;

namespace ECommerAPI.Persistance
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PersonalWebsiteAPIDbContext>
    {
        public PersonalWebsiteAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<PersonalWebsiteAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new PersonalWebsiteAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
