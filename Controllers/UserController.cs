using Microsoft.AspNetCore.Mvc;
using Sheffield_Car_Park_System.Dtos;

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

        [HttpGet]
        public ActionResult<AppResponse<List<User>>> Get()
        {
            return Ok(userService.GetAll());
        }

    }
}