using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eLearning.Core.Entities
{
    public class Answer : BaseEntity
    {
        public Guid QuestionId { get; set; }
        [ForeignKey(nameof(QuestionId))]
        public virtual Question Question { get; set; }
        public string AnswerValue { get; set; }
        public bool IsTrue { get; set; }
    }
}
