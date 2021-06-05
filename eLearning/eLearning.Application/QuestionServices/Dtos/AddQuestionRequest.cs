using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Core.Entities;

namespace eLearning.Application.QuestionServices.Dtos
{
    public class AddQuestionRequest
    {
        public Guid? LessionId { get; set; }
        public Guid? ExamId { get; set; }
        public string Content { get; set; }
        public virtual Question ToEntity() => new Question()
        {
            ExamId = ExamId,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
            Id = Guid.NewGuid(),
            Content = Content,
            LessionId = LessionId
        };
    }
}
