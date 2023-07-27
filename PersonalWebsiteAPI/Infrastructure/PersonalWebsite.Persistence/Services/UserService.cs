using Mapster;
using PersonalWebsiteAPI.Application.DTOs.Category;
using PersonalWebsiteAPI.Application.DTOs.User;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Application.Services;
using PersonalWebsiteAPI.Domain.Entities;
using PersonalWebsiteAPI.Persistence.Repositories;

namespace PersonalWebsiteAPI.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;
       
        public UserService(IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository)
        {
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
        }

        public  IQueryable<User> GetUsers()
        {
            return _userReadRepository.GetAll(true);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userReadRepository.GetByIdAsync(id);
        }
        public async Task<int> CreateUser(CreateUserDTO createUserDTO)
        {
           User user = createUserDTO.Adapt<User>();
           return await _userWriteRepository.AddAsync(user);
        }

        public async Task<User> UpdateUserByIdAsync(int id, UpdateUserDTO updateUserDTO)
        {
           var user =  updateUserDTO.Adapt(await GetUserByIdAsync(id));
            
            return await _userWriteRepository.UpdateAsync(user);
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            return await _userWriteRepository.RemoveAsyncById(id);
        }

        public async Task<User> SoftDeleteUserByIdAsync(int id, SoftDeleteUserDTO softDeleteUserDTO)
        {
            User user = await _userReadRepository.GetByIdAsync(id);
            user.IsDeleted = softDeleteUserDTO.IsDeleted;
            return await _userWriteRepository.UpdateAsync(user);
        }

    }
}
