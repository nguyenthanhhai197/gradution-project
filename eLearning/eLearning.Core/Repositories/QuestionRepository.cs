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
    public interface IQuestionRepository
    {
        Task<List<Question>> GetQuestionByLessionId(Guid id);
    }
    public class QuestionRepository : IQuestionRepository
    {
        private readonly eLearningDbcontext _context;

        public QuestionRepository(eLearningDbcontext context)
        {
            _context = context;
        }
        public async Task<List<Question>> GetQuestionByLessionId(Guid id)
        {
            var query = _context.Questions.Include(c => c.Lession).Where(d => d.LessionId == id);
            return await query.ToListAsync();
        }
    }
}
