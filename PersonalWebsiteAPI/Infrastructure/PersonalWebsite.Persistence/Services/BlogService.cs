using Mapster;
using PersonalWebsiteAPI.Application.DTOs.Blog;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Application.Services;
using PersonalWebsiteAPI.Domain.Entities;

namespace PersonalWebsiteAPI.Persistence.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogWriteRepository _blogWriteRepository;
        private readonly IBlogReadRepository _blogReadRepository;

        public BlogService(IBlogWriteRepository blogWriteRepository, IBlogReadRepository blogReadRepository)
        {
            _blogWriteRepository = blogWriteRepository;
            _blogReadRepository = blogReadRepository;
        }
        public IQueryable<Blog> GetBlogs()
        {
            return _blogReadRepository.GetAll();
        }
        public async Task<Blog> GetBlogByIdAsync(int id)
        {
            return await _blogReadRepository.GetByIdAsync(id);
        }

        public IQueryable<Blog> GetBlogsByCategoryId(int categoryId)
        {
            return _blogReadRepository.GetWhere(data => data.CategoryId == categoryId);
        }

        public IQueryable<Blog> GetBlogsByUserId(int userId)
        {
            return _blogReadRepository.GetWhere(data => data.UserId == userId);
        }

        public async Task<int> CreateBlogAsync(CreateBlogDTO createBlogDTO)
        {
            return await _blogWriteRepository.AddAsync(createBlogDTO.Adapt<Blog>());
        }

        public async Task<Blog> UpdateBlogByIdAsync(int id, UpdateBlogDTO updateBlogDTO)
        {
            Blog blog = updateBlogDTO.Adapt(await GetBlogByIdAsync(id));
            return await _blogWriteRepository.UpdateAsync(blog);
        }

        public async Task<bool> DeleteBlogByIdAsync(int id)
        {
            return await _blogWriteRepository.RemoveAsyncById(id);
        }

        public async Task<Blog> SoftDeleteBlogByIdAsync(int id)
        {
            var blog = await GetBlogByIdAsync(id);
            blog.IsDeleted = true;
            return await _blogWriteRepository.UpdateAsync(blog);
        }
    }
}
