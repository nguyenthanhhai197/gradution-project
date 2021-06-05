using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.CourseServices.Dto;
using eLearning.Common;
using eLearning.Core.Data;
using eLearning.Core.Entities;

namespace eLearning.Application.CourseServices
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course> _repository;

        public CourseService(IRepository<Course> repository)
        {
            this._repository = repository;
        }
        public async Task<Course> AddCourse(AddCourseRequest request)
        {
            return await _repository.AddAsync(request.ToEntiy());
        }

        public async Task DeleteCourse(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<Pagination<Course>> GetAllPaging(int? page = 1, int? pageSize = 10)
        {
            return await _repository.GetPagingAsync("", page.Value, pageSize.Value, new string[] { "Teacher" });
        }

        public async Task<Course> GetById(Guid id)
        {
            return await _repository.GetIncludeAsync(id, new string[] { "Lessions","Teacher" });
        }

        public async Task UpdateCourse(UpdateCourseRequest request)
        {
            await _repository.UpdateAsync(request.ToEntiy());
        }
    }
}
