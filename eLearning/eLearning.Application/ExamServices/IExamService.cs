using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.ExamServices.Dtos;
using eLearning.Common;
using eLearning.Core.Entities;

namespace eLearning.Application.ExamServices
{
    public interface IExamService
    {
        Task<Exam> AddExam(AddExamRequest request);
        Task UpdateExam(UpdateExamRequest request);
        Task DeleteExam(Guid id);
        Task<Pagination<Exam>> GetPaging(int page, int pagesize);
    }
}
