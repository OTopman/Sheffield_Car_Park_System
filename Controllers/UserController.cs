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

        [HttpPost("login")]
        
        public ActionResult<AppResponse<User>> Login([FromBody] LoginDto login)
        {
            return Ok(this.userService.Login(login));
        }

        [HttpGet]
        public ActionResult<AppResponse<List<User>>> Get()
        {
            return Ok(userService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<AppResponse<User>> Get(int id)
        {
            return Ok(userService.GetById(id));
        }

        [HttpPut]
        public ActionResult<AppResponse<User>> Put(EditUserDto userDto)
        {

            return Ok(userService.Update(new User()
            {
                Id = userDto.Id,
                EmailAddress = userDto.EmailAddress,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Password = userDto.Password,
            }));
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(userService.Delete(id));
        }
    }
}