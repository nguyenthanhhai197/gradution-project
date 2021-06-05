using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.CourseServices.Dto;
using eLearning.Common;
using eLearning.Core.Entities;

namespace eLearning.Application.CourseServices
{
    public interface ICourseService
    {
        Task<Course> AddCourse(AddCourseRequest request);
        Task UpdateCourse(UpdateCourseRequest request);
        Task<Pagination<Course>> GetAllPaging(int? page = 1, int? pageSize = 10);
        Task DeleteCourse(Guid id);
        Task<Course> GetById(Guid id);
    }
}
