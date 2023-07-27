using PersonalWebsiteAPI.Application.DTOs.User;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Domain.Entities;

namespace PersonalWebsiteAPI.Application.Services
{
    public interface IUserService
    {
        public Task<int> CreateUser(CreateUserDTO createUserDTO);

        public Task<User> DeleteUser(int id);

        public IQueryable<User> GetUsers();
    }
}
