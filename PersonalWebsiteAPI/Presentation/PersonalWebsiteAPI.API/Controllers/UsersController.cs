using Microsoft.AspNetCore.Mvc;
using PersonalWebsiteAPI.Application.DTOs.User;
using PersonalWebsiteAPI.Application.Services;

namespace PersonalWebsiteAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userService.GetUsers());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            return Ok(await _userService.GetUserByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] CreateUserDTO createUserDTO)
        {
            return Ok(await _userService.CreateUser(createUserDTO));
        }

        [HttpGet]
        [Route("UpdateUser/{id}")]
        public async Task<IActionResult> UpdateUser(int id)
        {
            return Ok(await _userService.GetUserByIdAsync(id));
        }

        [HttpPut]
        [Route("UpdateUser/{id}")]
        public async Task<IActionResult> UpdateUser(int id,[FromBody]UpdateUserDTO updateUserDTO)
        {
            
            return Ok(await _userService.UpdateUserByIdAsync(id,updateUserDTO));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _userService.DeleteUserAsync(id);
            return Ok();
        }
    }
}
