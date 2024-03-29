﻿using Microsoft.EntityFrameworkCore;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Domain.Entities.Common;
using PersonalWebsiteAPI.Persistence.Context;
using System.Linq.Expressions;

namespace PersonalWebsiteAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly PersonalWebsiteAPIDbContext _context;
        public ReadRepository(PersonalWebsiteAPIDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {

            var query = Table.AsQueryable().Where(data => data.IsDeleted == false);
            if(!tracking)
            {
               query = query.AsNoTracking();
            }
            return query;
        }

        public async Task<T> GetByIdAsync(int id, bool tracking = true)
        {
            var query = Table.Where(data => data.Id == id);
            if(!tracking)
            {
                query = Table.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if(!tracking)
            {
                query = Table.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if(!tracking)
            {
               query =  query.AsNoTracking();
            }
            return query;
        }
    }
}
