using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eLearning.Common;
using eLearning.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace eLearning.Core.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly eLearningDbcontext _context;

        public Repository(eLearningDbcontext context)
        {
            this._context = context;
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRangeAsync(Guid[] ids)
        {
            var entities = _context.Set<TEntity>().Where(c => ids.Contains(c.Id));
            _context.Set<TEntity>().RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(string keyword)
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetAsync(Guid id)
        {
            return await _context.Set<TEntity>().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<TEntity> GetIncludeAsync(Guid id, IEnumerable<string> includes)
        {
            var query = _context.Set<TEntity>().AsQueryable();
            if (includes?.FirstOrDefault() != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return await query.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<TEntity> GetNoTrackingAsync(Guid id)
        {
            return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Pagination<TEntity>> GetPagingAsync(string keyword, int page, int pageSize, IEnumerable<string> includes)
        {
            var query = _context.Set<TEntity>().AsQueryable();
            if (includes?.FirstOrDefault() != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            query = query.OrderByDescending(c => c.CreatedAt);
            var data = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            var totalRows = await query.CountAsync();
            return new Pagination<TEntity>(data, totalRows, page, pageSize);

        }

        public IQueryable<TEntity> GetQueryable(IEnumerable<string> includes = null)
        {
            var query = _context.Set<TEntity>().AsQueryable();
            if (includes?.FirstOrDefault() != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return query;
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Entry(entity).Property(c => c.CreatedAt).IsModified = false;
            await _context.SaveChangesAsync();
        }
    }
}
