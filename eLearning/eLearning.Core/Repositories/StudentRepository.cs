using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eLearning.Core.Data;
using eLearning.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace eLearning.Core.Repositories
{
    public interface IStudentRepository
    {
        Task<bool> StudentLogin(string username, string password);
        Task AddLessionStudent(Guid lessionId, Guid studentId);
    }
    public class StudentRepository : IStudentRepository
    {
        private readonly eLearningDbcontext _context;

        public StudentRepository(eLearningDbcontext context)
        {
            _context = context;
        }

        public async Task AddLessionStudent(Guid lessionId, Guid studentId)
        {
            var add = new StudentLession()
            {
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                LessionId = lessionId,
                StudentId = studentId,
                Id = Guid.NewGuid()
            };
            _context.StudentLessions.Add(add);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> StudentLogin(string username, string password)
        {
            return await _context.Students.AnyAsync(c => c.Username == username && c.Password == password);
        }
    }
}
