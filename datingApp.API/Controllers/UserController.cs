using System.Threading.Tasks;
using datingApp.API.Data;
using datingApp.API.DTOS;
using datingApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace datingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public UserController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserToCreateDTO userToCreateDTO){

            userToCreateDTO.UserName=userToCreateDTO.UserName.ToLower();
            if(await _repo.UserExists(userToCreateDTO.UserName))
                return BadRequest("User already exist");
            var UserToCreate = new User{
                UserName = userToCreateDTO.UserName
            };
            var CreatedUser = await _repo.Register(UserToCreate,userToCreateDTO.Password);
            return StatusCode(201);
        }
    }
}