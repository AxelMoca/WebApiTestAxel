using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiTestMobileAxel.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        //[HttpGet]
        //public ActionResult<List<User>> GetUsers()
        //{
        //    var users = _userService.GetUsers();
        //    return Ok(users);
        //}

        [HttpGet]
        public List<User> GetUsers()
        {
            var users = _userService.GetUsers();
            return (users);
        }
    }
}
