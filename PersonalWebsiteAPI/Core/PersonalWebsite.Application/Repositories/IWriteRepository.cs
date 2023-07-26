﻿using PersonalWebsiteAPI.Domain.Entities.Common;

namespace PersonalWebsiteAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<int> AddAsync(T model,CancellationToken cancellationToken);
        Task<bool> AddRangeAsync(List<T> datas);
        bool Remove(T model);
        bool RemoveRange(List<T> datas);
        Task<bool> RemoveAsyncById(int id);
        bool Update(T model);
        Task<int> SaveChangesAsync();
    }
}
