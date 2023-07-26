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
        public async Task<int> CreateUser(CreateUserDTO createUserDTO,CancellationToken cancellationToken)
        {
            User user = new User()
            {
                FirstName = createUserDTO.FirstName,
                LastName = createUserDTO.LastName,
                EMail = createUserDTO.Email,
                Password = createUserDTO.Password
            };
            return await _userWriteRepository.AddAsync(user,cancellationToken);
            
        }

        public Task<User> DeleteUser(int id)
        {
            _userWriteRepository.RemoveAsyncById(id);
            return null;
        }
    }
}
