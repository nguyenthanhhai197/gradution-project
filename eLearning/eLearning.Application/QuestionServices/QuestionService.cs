using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.QuestionServices.Dtos;
using eLearning.Core.Data;
using eLearning.Core.Entities;
using eLearning.Core.Repositories;

namespace eLearning.Application.QuestionServices
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IRepository<Question> _repository;

        public QuestionService(IQuestionRepository questionRepository, IRepository<Question> repository)
        {
            this._questionRepository = questionRepository;
            this._repository = repository;
        }

        public async Task<Question> AddQuestion(AddQuestionRequest request)
        {
            return await _repository.AddAsync(request.ToEntity());
        }

        public async Task DeleteQuestion(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<List<Question>> GetQuestionsByLessionId(Guid id)
        {
            return await _questionRepository.GetQuestionByLessionId(id);
        }

        public async Task UpdateQuestion(UpdateQuestionRequest request)
        {
            await _repository.UpdateAsync(request.ToEntity());
        }
    }
}
