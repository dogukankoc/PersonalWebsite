using PersonalWebsiteAPI.Application.DTOs.Category;
using PersonalWebsiteAPI.Domain.Entities;

namespace PersonalWebsiteAPI.Application.Services
{
    public interface ICategoryService
    {
        public Task<Category> GetCategoriesByIdAsync(int id);
        public IQueryable<Category> GetCategories();
        public Task<int> AddCategoryAsync(CreateCategoryDTO createCategoryDTO);
        public Task<Category> UpdateCategoryByIdAsync(int id, UpdateCategoryDTO updateCategoryDTO);
        public Task<bool> DeleteCategoryByIdAsync(int id);
        public Task<Category> SoftDeleteCategoryByIdAsync(int id);

    }
}
