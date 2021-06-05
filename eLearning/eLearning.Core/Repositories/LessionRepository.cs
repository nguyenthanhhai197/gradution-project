using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eLearning.Common;
using eLearning.Core.Data;
using eLearning.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace eLearning.Core.Repositories
{
    public interface ILessionRepository
    {
        Task<List<Lession>> GetAllByCourseId(Guid id);
    }
    public class LessionRepository : ILessionRepository
    {
        private readonly eLearningDbcontext _context;

        public LessionRepository(eLearningDbcontext context)
        {
            this._context = context;
        }
        public async Task<List<Lession>> GetAllByCourseId(Guid id)
        {
            var query = _context.Lessions.Include(c => c.Teacher).Where(c => c.CourseId == id);
            return await query.ToListAsync();
        }
    }
}
