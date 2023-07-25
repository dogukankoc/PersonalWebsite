using Microsoft.EntityFrameworkCore;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Domain.Entities.Common;
using PersonalWebsiteAPI.Persistence.Context;
using System.Linq.Expressions;

namespace PersonalWebsiteAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly PersonalWebsiteAPIDbContext _context;
        public ReadRepository(PersonalWebsiteAPIDbContext _context) 
        {
            _context = _context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        {
            var query = Table.AsQueryable();
            return query;
        }
        
        public async Task<T> GetByIdAsync(int id)
        {
            var query = Table.AsQueryable();
            return await Table.FirstOrDefaultAsync(data => data.Id == id);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        {
            var query = Table.AsQueryable();
            return await query.FirstOrDefaultAsync(method);
        }

            public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        {
            var query = Table.Where(method);
            return query;
        }
    }
}
