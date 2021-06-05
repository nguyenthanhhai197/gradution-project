using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Core.Entities;

namespace eLearning.Application.LessionServices.Dtos
{
    public class AddLessionRequest
    {
        public string Name { get; set; }
        public Guid CourseId { get; set; }
        public string VideoUrl { get; set; }
        public string Content { get; set; }
        public virtual Lession ToEntity() => new Lession()
        {
            Id = Guid.NewGuid(),
            Content = Content,
            CourseId = CourseId,
            CreatedAt = DateTime.Now,
            Name = Name,
            UpdatedAt = DateTime.Now,
            VideoUrl = VideoUrl
        };
    }
}
