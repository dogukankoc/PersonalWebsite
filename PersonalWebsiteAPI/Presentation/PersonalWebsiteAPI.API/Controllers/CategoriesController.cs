using Microsoft.AspNetCore.Mvc;
using PersonalWebsiteAPI.Application.DTOs.Category;
using PersonalWebsiteAPI.Application.Services;

namespace PersonalWebsiteAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Categories()
        {
            return Ok(_categoryService.GetCategories());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            return Ok(await _categoryService.GetCategoriesByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDTO createCategoryDTO)
        {
            return Ok(await _categoryService.AddCategoryAsync(createCategoryDTO));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id,UpdateCategoryDTO updateCategoryDTO)
        {
            return Ok(await _categoryService.UpdateCategoryByIdAsync(id, updateCategoryDTO));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            return Ok(await _categoryService.DeleteCategoryByIdAsync(id));
        }
    }
}
