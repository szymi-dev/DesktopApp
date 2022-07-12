using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class RegisterDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
         public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}