using Microsoft.EntityFrameworkCore;

namespace PersonalWebsiteAPI.Application.Repositories
{
    public interface IRepository<T>  where T : class
    {
        DbSet<T> Table { get; }
    }
}
