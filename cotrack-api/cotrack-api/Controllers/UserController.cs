using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cotrack_api.Interfaces;
using cotrack_api.Models;
using cotrack_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace cotrack_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserService _usuarioService;

        public UserController(UserService userService)
        {
            _usuarioService = userService;
        }


        [HttpGet("{id:length(24)}", Name = "GetUser")]
        public ActionResult<User> Find(string id)
        {
            var usuario = _usuarioService.Find(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        [HttpGet]
        public List<User> FindAll()
        {
            var usuario = _usuarioService.FindAll();
            return usuario;
        }

        [HttpPost]
        public ActionResult<User> Save(User user)
        {
            var createUser = _usuarioService.Save(user);
            return createUser;
        }


        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, User userIn)
        {
            var user = _usuarioService.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            _usuarioService.Update(id, userIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var user = _usuarioService.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            _usuarioService.Remove(user.Id);

            return NoContent();
        }
    }
}