using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cotrack_webApi.Interfaces;
using cotrack_webApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace cotrack_webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public User Save(User user)
        {
            var createUser = _userService.Save(user);
            return createUser;
        }
    }
}