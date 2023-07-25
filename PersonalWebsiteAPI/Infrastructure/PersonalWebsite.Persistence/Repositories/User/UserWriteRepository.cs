using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Domain.Entities;
using PersonalWebsiteAPI.Persistence.Context;

namespace PersonalWebsiteAPI.Persistence.Repositories
{
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(PersonalWebsiteAPIDbContext context) : base(context)
        {
        }
    }
}
