using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Core.Entities;

namespace eLearning.Application.LessionServices.Dtos
{
    public class UpdateLessionRequest : AddLessionRequest
    {
        public Guid Id { get; set; }
        public override Lession ToEntity() => new Lession()
        {
            Id = Id,
            Content = Content,
            CourseId = CourseId,
            CreatedAt = DateTime.Now,
            Name = Name,
            UpdatedAt = DateTime.Now,
            VideoUrl = VideoUrl
        };
    }
}
