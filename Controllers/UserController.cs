using Microsoft.AspNetCore.Mvc;
using Sheffield_Car_Park_System.Dtos;
using Sheffield_Car_Park_System.Models;

namespace Sheffield_Car_Park_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public ActionResult<AppResponse<User>> Login([FromBody] LoginDto login)
        {
            return Ok(this.userService.Login(login));
        }

    }
}