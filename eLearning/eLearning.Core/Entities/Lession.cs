using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eLearning.Core.Entities
{
    public class Lession : BaseEntity
    {
        public string Name { get; set; }
        public Guid CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]
        public virtual Course Course { get; set; }
        public string VideoUrl { get; set; }
        public string Content { get; set; }
        public string Teacher { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
