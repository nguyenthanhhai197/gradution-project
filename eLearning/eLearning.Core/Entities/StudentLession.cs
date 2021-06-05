using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eLearning.Core.Entities
{
    public class StudentLession : BaseEntity
    {
        public Guid LessionId { get; set; }
        [ForeignKey(nameof(LessionId))]
        public virtual Lession Lession { get; set; }
        public Guid StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public virtual Student Student { get; set; }
    }
}
