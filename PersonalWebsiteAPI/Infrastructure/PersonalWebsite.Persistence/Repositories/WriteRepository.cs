using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Domain.Entities.Common;
using PersonalWebsiteAPI.Persistence.Context;

namespace PersonalWebsiteAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly PersonalWebsiteAPIDbContext _context;

        public WriteRepository(PersonalWebsiteAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<int> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            entityEntry.State = EntityState.Added;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        //TODO RemoveAsync araştırılacak.
        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            var entityState = entityEntry.State == EntityState.Deleted;
            _context.SaveChanges();
            return entityState;
        }

        public async Task<bool> RemoveAsyncById(int id)
        {
            T model = await Table.FirstOrDefaultAsync(data => data.Id == id);
            return Remove(model);
        }

        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<T> UpdateAsync(T model)
        {
            EntityEntry<T> entityEntry = Table.Update(model);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return model;
        }


        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();

        
    }
}
