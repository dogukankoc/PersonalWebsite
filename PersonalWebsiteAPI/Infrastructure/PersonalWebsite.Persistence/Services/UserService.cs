using Mapster;
using PersonalWebsiteAPI.Application.DTOs.User;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Application.Services;
using PersonalWebsiteAPI.Domain.Entities;

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
        public async Task<int> CreateUser(CreateUserDTO createUserDTO)
        {
           User user = createUserDTO.Adapt<User>();
           return await _userWriteRepository.AddAsync(user);
        }

        public Task<User> DeleteUser(int id)
        {
            _userWriteRepository.RemoveAsyncById(id);
            return null;
        }

        
    }
}
