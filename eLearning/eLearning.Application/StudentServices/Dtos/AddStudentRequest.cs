using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Core.Entities;
using Microsoft.AspNetCore.Http;

namespace eLearning.Application.StudentServices.Dtos
{
    public class AddStudentRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Dob { get; set; }
        public string School { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public IFormFile File { get; set; }
        public virtual Student ToEntity() => new Student()
        {
            Dob = Dob,
            Password = Password,
            Address = Address,
            Class = Class,
            CreatedAt = DateTime.Now,
            Email = Email,
            Id = Guid.NewGuid(),
            Name = Name,
            Phone = Phone,
            School = School,
            UpdatedAt = DateTime.Now,
            Username = Username
        };
    }
}
