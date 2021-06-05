using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Common;
using eLearning.Core.Entities;

namespace eLearning.Application.FileServices.Dtos
{
    public class AddFileRequest
    {
        public string Name { get; set; }
        public EnumFile FileType { get; set; }
        public Guid IdMapping { get; set; }
        public File ToEntity() => new File()
        {
            CreatedAt = DateTime.Now,
            FilePath = string.Empty,
            FileType = FileType,
            Id = Guid.NewGuid(),
            MappingId = IdMapping,
            Name = Name,
            UpdatedAt = DateTime.Now
        };
    }
}
