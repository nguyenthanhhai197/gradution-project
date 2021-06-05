using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.StudentServices.Dtos;
using eLearning.Core.Data;
using eLearning.Core.Entities;
using eLearning.Core.Repositories;

namespace eLearning.Application.StudentServices
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;
        private readonly IRepository<Student> _studentRepository;

        public StudentService(IStudentRepository repository, IRepository<Student> studentRepository)
        {
            _repository = repository;
            _studentRepository = studentRepository;
        }
        public async Task<bool> Login(StudentLogin request)
        {
            return await _repository.StudentLogin(request.Username, request.Password);
        }

        public async Task<Student> Register(AddStudentRequest request)
        {
            var entity = request.ToEntity();
            return await _studentRepository.AddAsync(entity);
        }
    }
}
