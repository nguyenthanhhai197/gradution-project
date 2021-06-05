using System;
using System.Collections.Generic;
using System.Text;

namespace eLearning.Core.Entities
{
    public class Exam : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
