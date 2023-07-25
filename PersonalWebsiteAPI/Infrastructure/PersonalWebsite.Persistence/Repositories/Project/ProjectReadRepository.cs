using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Domain.Entities;
using PersonalWebsiteAPI.Persistence.Context;

namespace PersonalWebsiteAPI.Persistence.Repositories
{
    public class ProjectReadRepository : ReadRepository<Project>, IProjectReadRepository
    {
        public ProjectReadRepository(PersonalWebsiteAPIDbContext _context) : base(_context)
        {
        }
    }
}
