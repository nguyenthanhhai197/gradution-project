using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Application.AccountServices;
using eLearning.Application.CourseServices;
using eLearning.Application.ExamServices;
using eLearning.Application.FileServices;
using eLearning.Application.LessionServices;
using eLearning.Application.QuestionServices;
using eLearning.Application.StudentServices;
using eLearning.Application.TeacherServices;
using eLearning.Core.Data;
using eLearning.Core.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eLearning.Application.DependencyInjection
{
    public static class ServiceCollection
    {
        public static void AddServices(this IServiceCollection service)
        {
            service.AddScoped(typeof(IRepository<>),typeof(Repository<>));

            service.AddScoped<IAccountRepository, AccountRepository>();
            service.AddScoped<ILessionRepository, LessionRepository>();
            service.AddScoped<IQuestionRepository, QuestionRepository>();
            service.AddScoped<IStudentRepository, StudentRepository>();

            service.AddScoped<IAccountService, AccountService>();
            service.AddScoped<ICourseService, CourseService>();
            service.AddScoped<IExamService, ExamService>();
            service.AddScoped<ILessionService, LessionService>();
            service.AddScoped<IQuestionService, QuestionService>();
            service.AddScoped<IStudentService, StudentService>();
            service.AddScoped<ITeacherService, TeacherService>();
            service.AddScoped<IFileService, FileServicecs>();
        }
    }
}
