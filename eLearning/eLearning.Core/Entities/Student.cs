using System;
using System.Collections.Generic;
using System.Text;

namespace eLearning.Core.Entities
{
    public class Student : BaseEntity
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
    }
}
