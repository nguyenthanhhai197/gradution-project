using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eLearning.Core.Entities
{
    public class Question : BaseEntity
    {
        public Guid? LessionId { get; set; }
        [ForeignKey(nameof(LessionId))]
        public virtual Lession Lession { get; set; }
        public Guid? ExamId { get; set; }
        [ForeignKey(nameof(ExamId))]
        public virtual Exam Exam { get; set; }
        public string Content { get; set; }
    }
}
