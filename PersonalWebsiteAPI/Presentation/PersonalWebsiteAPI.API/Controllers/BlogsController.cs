using Microsoft.AspNetCore.Mvc;
using PersonalWebsiteAPI.Application.DTOs.Blog;
using PersonalWebsiteAPI.Application.Services;

namespace PersonalWebsiteAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService _blogService;
        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        public IActionResult Blogs()
        {
            return Ok(_blogService.GetBlogs());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BlogById(int id)
        {
            return Ok(await _blogService.GetBlogByIdAsync(id));
        }

        [HttpGet]
        [Route("category/{categoryId}")]
        public IActionResult BlogsByCategoryId(int categoryId)
        {
            return Ok(_blogService.GetBlogsByCategoryId(categoryId));
        }

        [HttpGet]
        [Route("user/{userId}")]
        public IActionResult BlogsByUserId(int userId)
        {
            return Ok(_blogService.GetBlogsByUserId(userId));
        }
        [HttpGet]
        [Route("lastblogs/{number}")]
        public IActionResult LastBlogs(int number)
        {
            return Ok(_blogService.LastBlogsByNumber(number));
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogDTO createBlogDTO)
        {
            return Ok(await _blogService.CreateBlogAsync(createBlogDTO));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog(int id, UpdateBlogDTO updateBlogDTO)
        {
            return Ok(await _blogService.UpdateBlogByIdAsync(id,updateBlogDTO));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            return Ok(await _blogService.DeleteBlogByIdAsync(id));
        }

        [HttpPut]
        [Route("softdelete/{id}")]
        public async Task<IActionResult> SoftDeleteBlogById(int id)
        {
            return Ok(await _blogService.SoftDeleteBlogByIdAsync(id));
        }
    }
}
