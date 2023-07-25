using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Domain.Entities;
using PersonalWebsiteAPI.Persistence.Context;

namespace PersonalWebsiteAPI.Persistence.Repositories
{
    public class BlogReadRepository : ReadRepository<Blog>, IBlogReadRepository
    {
        public BlogReadRepository(PersonalWebsiteAPIDbContext _context) : base(_context)
        {
        }
    }
}
