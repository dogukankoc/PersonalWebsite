using PersonalWebsiteAPI.Application.DTOs.User;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Domain.Entities;

namespace PersonalWebsiteAPI.Application.Services
{
    public interface IUserService
    {
        public IQueryable<User> GetUsers();

        public Task<User> GetUserByIdAsync(int id);
        public Task<int> CreateUser(CreateUserDTO createUserDTO);

        public Task<User> UpdateUserByIdAsync(int id,UpdateUserDTO updateUserDTO);

        public Task<bool> DeleteUserAsync(int id);

    }
}
