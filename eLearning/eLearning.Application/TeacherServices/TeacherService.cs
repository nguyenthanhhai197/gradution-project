using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.TeacherServices.Dtos;
using eLearning.Core.Data;
using eLearning.Core.Entities;

namespace eLearning.Application.TeacherServices
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepository<Teacher> _repository;

        public TeacherService(IRepository<Teacher> repository)
        {
            this._repository = repository;
        }
        public async Task AddTeacher(AddTeacherRequest request)
        {
            var entity = request.ToEntity();
            await _repository.AddAsync(entity);
        }

        public async Task<IEnumerable<Teacher>> GetAll()
        {
            var entites = await _repository.GetAllAsync("");
            return entites.ToList();
        }

        public async Task UpdateTeacher(UpdateTeacherRequest request)
        {
            var entity = request.ToEntity();
            await _repository.UpdateAsync(entity);
        }
    }
}
