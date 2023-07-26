using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsiteAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {

        public IActionResult GetBlogs()
        {
            return Ok();
        }

        public IActionResult GetBlogById(int id) 
        {
            return Ok();
        }

        public IActionResult GetBlogsByCategoryId (int categoryId) 
        {
            return Ok();
        }

        public IActionResult CreateBlog()
        {
            return Ok();
        }

        public IActionResult UpdateBlog(int id)
        {
            return Ok();
        }

        public IActionResult DeleteBlog(int id) 
        {
            return Ok();
        }

        public IActionResult DeleteBlogsByCategoryId(int categoryıd)
        {
            return Ok();
        }
        public IActionResult DeleteBlogs()
        {
            return Ok();
        }

    }
}
