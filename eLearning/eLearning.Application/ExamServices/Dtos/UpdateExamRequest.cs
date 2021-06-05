using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Core.Entities;

namespace eLearning.Application.ExamServices.Dtos
{
    public class UpdateExamRequest : AddExamRequest
    {
        public Guid Id { get; set; }
        public override Exam ToEntity() => new Exam()
        {
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
            Description = Description,
            Id = Id,
            Name = Name
        };
    }
}
