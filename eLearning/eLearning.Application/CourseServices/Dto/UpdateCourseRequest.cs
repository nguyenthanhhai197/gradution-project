using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Core.Entities;

namespace eLearning.Application.CourseServices.Dto
{
    public class UpdateCourseRequest : AddCourseRequest
    {
        public Guid Id { get; set; }
        public override Course ToEntiy() => new Course()
        {
            CreatedAt = DateTime.Now,
            Description = Description,
            Group = Group,
            Name = Name,
            Order = Order,
            TeacherId = TeacherId,
            UpdatedAt = DateTime.Now,
            Id = Id
        };
    }
}
