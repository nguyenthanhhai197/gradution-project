using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.StudentServices.Dtos;
using eLearning.Core.Entities;

namespace eLearning.Application.StudentServices
{
    public interface IStudentService
    {
        Task<bool> Login(StudentLogin request);
        Task<Student> Register(AddStudentRequest request);
    }
}
