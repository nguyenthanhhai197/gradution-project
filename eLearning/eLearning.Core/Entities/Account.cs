using System;
using System.Collections.Generic;
using System.Text;
using eLearning.Common;

namespace eLearning.Core.Entities
{
    public class Account : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public EnumAccountRole Role { get; set; }
    }
}
