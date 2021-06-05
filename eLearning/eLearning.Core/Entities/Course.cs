using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using eLearning.Common;

namespace eLearning.Core.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public EnumCourseGroup Group { get; set; }
        public virtual ICollection<Lession> Lessions { get; set; }
        public Guid TeacherId { get; set; }
        [ForeignKey(nameof(TeacherId))]
        public virtual Teacher Teacher { get; set; }
    }
}
