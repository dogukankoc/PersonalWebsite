using Mapster;
using PersonalWebsiteAPI.Application.DTOs.Category;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Application.Services;
using PersonalWebsiteAPI.Domain.Entities;

namespace PersonalWebsiteAPI.Persistence.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryWriteRepository _categoryWriteRepository;
        private readonly ICategoryReadRepository _categoryReadRepository;
        public CategoryService(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository)
        {

            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }

        public async Task<Category> GetCategoriesByIdAsync(int id)
        {
            return await _categoryReadRepository.GetByIdAsync(id);
        }

        public IQueryable<Category> GetCategories()
        {
            return _categoryReadRepository.GetAll();
        }

        public async Task<int> AddCategoryAsync(CreateCategoryDTO createCategoryDTO)
        {
           Category category = createCategoryDTO.Adapt<Category>();
            return await _categoryWriteRepository.AddAsync(category);
        }

        public async Task<Category> UpdateCategoryByIdAsync(int id, UpdateCategoryDTO updateCategoryDTO)
        {
            Category category = updateCategoryDTO.Adapt(await GetCategoriesByIdAsync(id));
            return await _categoryWriteRepository.UpdateAsync(category);
        }

        public async Task<bool> DeleteCategoryByIdAsync(int id)
        {
            return await _categoryWriteRepository.RemoveAsyncById(id);
        }

        public async Task<Category> SoftDeleteCategoryByIdAsync(int id, SoftDeleteCategoryDTO softDeleteCategoryDTO)
        {
            Category category = await _categoryReadRepository.GetByIdAsync(id);
            category.IsDeleted = softDeleteCategoryDTO.IsDeleted;
            return await _categoryWriteRepository.UpdateAsync(category);
        }

    }
}
