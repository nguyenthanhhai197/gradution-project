using System;
using System.Collections.Generic;
using System.Text;

namespace eLearning.Core.Entities
{
    public class Teacher : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public bool? Gender { get; set; }
        public string Avatar { get; set; }
        public string Degree { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
