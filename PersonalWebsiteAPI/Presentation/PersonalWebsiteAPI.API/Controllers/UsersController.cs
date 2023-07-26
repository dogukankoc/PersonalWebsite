using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsiteAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public IActionResult GetUsers()
        {
            return Ok();
        }

        public IActionResult GetUserById(int id)

        {
            return Ok();
        }

        public IActionResult CreateUser()
        {
            return Ok();
        }

        public IActionResult UpdateUser(int id)
        {
            return Ok();
        }

        public IActionResult DeleteUser(int id) 
        {
            return Ok();
        }
      
    }
}
