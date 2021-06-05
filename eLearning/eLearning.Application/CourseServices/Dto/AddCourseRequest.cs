using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Common;
using eLearning.Core.Entities;

namespace eLearning.Application.CourseServices.Dto
{
    public class AddCourseRequest
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public EnumCourseGroup Group { get; set; }
        public Guid TeacherId { get; set; }
        public virtual Course ToEntiy() => new Course()
        {
            CreatedAt = DateTime.Now,
            Description = Description,
            Group = Group,
            Name = Name,
            Order = Order,
            TeacherId = TeacherId,
            UpdatedAt = DateTime.Now
        };
    }
}
