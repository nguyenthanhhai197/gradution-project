using System;
using System.Collections.Generic;
using System.Text;

namespace eLearning.Application.AccountServices.Dtos
{
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
