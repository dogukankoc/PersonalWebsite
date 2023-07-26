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

        public async Task<int> AddAsync(T model, CancellationToken cancellationToken)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model, cancellationToken);
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
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsyncById(int id)
        {
            T model = await Table.FirstOrDefaultAsync(data => data.Id == id);
            await _context.SaveChangesAsync();
            return Remove(model);
        }

        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public bool Update(T model)
        {
            EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}
