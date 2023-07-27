using PersonalWebsiteAPI.Domain.Entities.Common;

namespace PersonalWebsiteAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<int> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> datas);
        bool Remove(T model);
        bool RemoveRange(List<T> datas);
        Task<bool> RemoveAsyncById(int id);
        Task<T> UpdateAsync(T model);
        Task<int> SaveChangesAsync();
    }
}
