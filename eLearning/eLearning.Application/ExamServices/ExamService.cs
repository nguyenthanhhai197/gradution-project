using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.ExamServices.Dtos;
using eLearning.Common;
using eLearning.Core.Data;
using eLearning.Core.Entities;

namespace eLearning.Application.ExamServices
{
    public class ExamService : IExamService
    {
        private readonly IRepository<Exam> _repository;

        public ExamService(IRepository<Exam> repository)
        {
            this._repository = repository;
        }
        public async Task<Exam> AddExam(AddExamRequest request)
        {
            return await _repository.AddAsync(request.ToEntity());
        }

        public async Task DeleteExam(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<Pagination<Exam>> GetPaging(int page, int pagesize)
        {
            return await _repository.GetPagingAsync("", page, pagesize, new string[] { "Questions" });
        }

        public async Task UpdateExam(UpdateExamRequest request)
        {
            await _repository.UpdateAsync(request.ToEntity());
        }
    }
}
