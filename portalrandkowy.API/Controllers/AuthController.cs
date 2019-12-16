using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using portalrandkowy.API.Data;
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
        public async Task<IActionResult> Register(string username, string password){
            username = username.ToLower();
            if(await _repository.UserExists(username))
                return BadRequest("User with this name already exists!");
            var userToCreate = new User{
                Username = username
            };
            var createdUser = await _repository.Register(userToCreate, password);
            return StatusCode(201);
        }
    }
}