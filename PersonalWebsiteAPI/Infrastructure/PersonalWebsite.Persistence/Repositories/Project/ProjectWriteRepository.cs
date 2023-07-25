using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Domain.Entities;
using PersonalWebsiteAPI.Persistence.Context;

namespace PersonalWebsiteAPI.Persistence.Repositories
{
    public class ProjectWriteRepository : WriteRepository<Project>, IProjectWriteRepository
    {
        public ProjectWriteRepository(PersonalWebsiteAPIDbContext context) : base(context)
        {
        }
    }
}
