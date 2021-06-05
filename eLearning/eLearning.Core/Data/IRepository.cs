using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eLearning.Common;
using eLearning.Core.Entities;

namespace eLearning.Core.Data
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> AddAsync(TEntity entity);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        Task<List<TEntity>> GetAllAsync(string keyword);

        Task<Pagination<TEntity>> GetPagingAsync(string keyword, int page, int pageSize, IEnumerable<string> includes);

        Task<TEntity> GetAsync(Guid id);

        Task<TEntity> GetNoTrackingAsync(Guid id);

        Task<TEntity> GetIncludeAsync(Guid id, IEnumerable<string> includes);

        Task DeleteAsync(Guid id);

        Task DeleteRangeAsync(Guid[] ids);

        Task UpdateAsync(TEntity entity);

        IQueryable<TEntity> GetQueryable(IEnumerable<string> includes = null);
    }
}
