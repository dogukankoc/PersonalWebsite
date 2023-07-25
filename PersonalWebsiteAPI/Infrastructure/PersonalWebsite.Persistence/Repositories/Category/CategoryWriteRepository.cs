using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Domain.Entities;
using PersonalWebsiteAPI.Persistence.Context;

namespace PersonalWebsiteAPI.Persistence.Repositories
{
    public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(PersonalWebsiteAPIDbContext context) : base(context)
        {
        }
    }
}
