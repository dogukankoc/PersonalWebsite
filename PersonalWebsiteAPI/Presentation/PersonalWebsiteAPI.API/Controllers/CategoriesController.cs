using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsiteAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public IActionResult GetCategories()
        {
            return Ok();
        }

        public IActionResult GetCategoryById(int id) 
        {
            return Ok();
        }

        public IActionResult CreateCategory()
        {
            return Ok();
        }

        public IActionResult DeleteCategory(int id) 
        {
            return Ok();
        }

        public IActionResult UpdateCategory(int id)
        {
            return Ok();
        }
    }
}
