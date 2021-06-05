using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Core.Entities;

namespace eLearning.Application.QuestionServices.Dtos
{
    public class UpdateQuestionRequest : AddQuestionRequest
    {
        public Guid Id { get; set; }
        public override Question ToEntity() => new Question()
        {
            Id = Id,
            Content = Content,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
            LessionId = LessionId,
            ExamId = ExamId
        };
    }
}
