using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data;
using MyProject.Models;
using MyProject.Repositories;

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;

        public UserController(IUserRepository repo) 
        {
            _userRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRole()
        {
            try
            {
                return Ok(await _userRepo.GetAllUserAsync());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{userID}")]
        public async Task<IActionResult> GetUserByID(string userID)
        {
            var user = await _userRepo.GetUserAsync(userID);
            return user == null ? NotFound() : Ok(user);
        }
        [HttpPost]
        public async Task<IActionResult> AddNewUser(UserModel model)
        {
            try
            {
                var newUserId = await _userRepo.AddUserAsync(model);
                var user = await _userRepo.GetUserAsync(newUserId);
                return user == null ? NotFound() : Ok(user);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{userID}")]
        public async Task<IActionResult> UpdateSport(string userID, [FromBody] UserModel model)
        {
            if (userID != model.UserID)
            {
                return NotFound();
            }
            await _userRepo.UpdateUserAsync(userID, model);
            return Ok();
        }
        [HttpDelete("{userID}")]
        public async Task<IActionResult> DeleteSport(string userID)
        {
            await _userRepo.DeleteUserAsync(userID);
            return Ok();
        }
    }
}
