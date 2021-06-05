using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.QuestionServices.Dtos;
using eLearning.Common;
using eLearning.Core.Entities;

namespace eLearning.Application.QuestionServices
{
    public interface IQuestionService
    {
        Task<List<Question>> GetQuestionsByLessionId(Guid id);
        Task<Question> AddQuestion(AddQuestionRequest request);
        Task UpdateQuestion(UpdateQuestionRequest request);
        Task DeleteQuestion(Guid id);
    }
}
