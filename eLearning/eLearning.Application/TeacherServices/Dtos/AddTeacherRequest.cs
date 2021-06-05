using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Core.Entities;
using Microsoft.AspNetCore.Http;

namespace eLearning.Application.TeacherServices.Dtos
{
    public class AddTeacherRequest
    {
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public bool? Gender { get; set; }
        public string Avatar { get; set; }
        public string Degree { get; set; }
        public IFormFileCollection File { get; set; }
        public virtual Teacher ToEntity() => new Teacher()
        {
            Name = Name,
            Dob = Dob,
            Gender = Gender,
            Avatar = string.Empty,
            CreatedAt = DateTime.Now,
            Degree = Degree,
            UpdatedAt = DateTime.Now,
            Id = Guid.NewGuid()
        };
    }
}
