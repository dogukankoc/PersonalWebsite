using Microsoft.EntityFrameworkCore;
using PersonalWebsiteAPI.Application.DTOs.Blog;
using PersonalWebsiteAPI.Domain.Entities;

namespace PersonalWebsiteAPI.Application.Services
{
    public interface IBlogService
    {
        IQueryable<Blog> GetBlogs();
        Task<Blog> GetBlogByIdAsync(int id);
        IQueryable<Blog> GetBlogsByCategoryId(int categoryId);
        IQueryable<Blog> GetBlogsByUserId(int userId);
        Task<int> CreateBlogAsync(CreateBlogDTO createBlogDTO);
        Task<Blog> UpdateBlogByIdAsync(int id, UpdateBlogDTO updateBlogDTO);
        Task<bool> DeleteBlogByIdAsync(int id);
        Task<Blog> SoftDeleteBlogByIdAsync(int id);
        
        List<Blog> LastBlogsByNumber(int number);
    }
}
