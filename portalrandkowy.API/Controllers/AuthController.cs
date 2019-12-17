using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using portalrandkowy.API.Data;
using portalrandkowy.API.Dtos;
using portalrandkowy.API.Models;

namespace portalrandkowy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public IAuthRepository _repository { get; }
        public AuthController(IAuthRepository repository)
        {
            _repository = repository;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto){

            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();
            if(await _repository.UserExists(userForRegisterDto.Username))
                return BadRequest("User with this name already exists!");
            var userToCreate = new User{
                Username = userForRegisterDto.Username
            };
            var createdUser = await _repository.Register(userToCreate, userForRegisterDto.Password);
            return StatusCode(201);

        }
    }
}