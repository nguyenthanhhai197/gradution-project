using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Core.Entities;

namespace eLearning.Application.TeacherServices.Dtos
{
    public class UpdateTeacherRequest : AddTeacherRequest
    {
        public Guid Id { get; set; }
        public override Teacher ToEntity() => new Teacher()
        {
            Name = Name,
            Dob = Dob,
            Gender = Gender,
            Avatar = string.Empty,
            CreatedAt = DateTime.Now,
            Degree = Degree,
            UpdatedAt = DateTime.Now,
            Id = Id
        };
    }
}
