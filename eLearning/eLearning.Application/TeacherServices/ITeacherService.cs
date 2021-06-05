using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.TeacherServices.Dtos;
using eLearning.Core.Entities;

namespace eLearning.Application.TeacherServices
{
    public interface ITeacherService
    {
        Task AddTeacher(AddTeacherRequest request);
        Task UpdateTeacher(UpdateTeacherRequest request);
        Task<IEnumerable<Teacher>> GetAll();
    }
}
