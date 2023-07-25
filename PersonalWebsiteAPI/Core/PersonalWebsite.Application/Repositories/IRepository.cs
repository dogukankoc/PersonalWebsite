using Microsoft.EntityFrameworkCore;
using PersonalWebsiteAPI.Domain.Entities.Common;

namespace PersonalWebsiteAPI.Application.Repositories
{
    public interface IRepository<T>  where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
