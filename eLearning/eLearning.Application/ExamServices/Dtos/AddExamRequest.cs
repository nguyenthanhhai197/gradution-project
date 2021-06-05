using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Core.Entities;

namespace eLearning.Application.ExamServices.Dtos
{
    public class AddExamRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Exam ToEntity() => new Exam()
        {
            Id = Guid.NewGuid(),
            CreatedAt = DateTime.Now,
            Description = Description,
            Name = Name,
            UpdatedAt = DateTime.Now
        };
    }
}
