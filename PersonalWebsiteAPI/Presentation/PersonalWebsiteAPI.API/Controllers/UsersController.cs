using Microsoft.AspNetCore.Http;
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
        
        public UsersController (IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDTO createUserDTO, CancellationToken cancellationToken)
        {

            return Ok(await _userService.CreateUser(createUserDTO, cancellationToken));
        }
        //public IActionResult GetUsers()
        //{
        //    return Ok();
        //}

        //public IActionResult GetUserById(int id)

        //{
        //    return Ok();
        //}



        //public IActionResult UpdateUser(int id)
        //{
        //    return Ok();
        //}
        [HttpDelete]
        public IActionResult DeleteUser([FromBody]int id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }

    }
}
