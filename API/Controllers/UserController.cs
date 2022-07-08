using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UserController : BaseController
    {
        public UserController()
        {

        }

        [HttpGet]
        public string GetUsers()
        {
            return "This will be list of users";
        }
    }
}