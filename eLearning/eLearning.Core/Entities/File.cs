using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Common;

namespace eLearning.Core.Entities
{
    public class File : BaseEntity
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
        public EnumFile FileType { get; set; }
        public Guid MappingId { get; set; }
    }
}
