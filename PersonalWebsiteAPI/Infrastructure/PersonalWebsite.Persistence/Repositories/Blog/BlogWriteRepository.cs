using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Domain.Entities;
using PersonalWebsiteAPI.Persistence.Context;

namespace PersonalWebsiteAPI.Persistence.Repositories
{
    public class BlogWriteRepository : WriteRepository<Blog>, IBlogWriteRepository
    {
        public BlogWriteRepository(PersonalWebsiteAPIDbContext context) : base(context)
        {
        }
    }
}
