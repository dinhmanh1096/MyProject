using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data;
using MyProject.Models;
using MyProject.Repositories;

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepo;

        public RoleController(IRoleRepository repo) 
        {
            _roleRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRole()
        {
            try
            {
                return Ok(await _roleRepo.GetAllRoleAsync());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{roleId}")]
        public async Task<IActionResult> GetRoleByID(string roleId)
        {
            var role = await _roleRepo.GetRoleAsync(roleId);
            return role == null ? NotFound() : Ok(role);
        }
        [HttpPost]
        public async Task<IActionResult> AddNewRole(RoleModel model)
        {
            try
            {
                var newRoleId = await _roleRepo.AddRoleAsync(model);
                var role = await _roleRepo.GetRoleAsync(newRoleId);
                return role == null ? NotFound() : Ok(role);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{roleId}")]
        public async Task<IActionResult> UpdateSport(string roleId, [FromBody] RoleModel model)
        {
            if (roleId != model.RoleID)
            {
                return NotFound();
            }
            await _roleRepo.UpdateRoleAsync(roleId, model);
            return Ok();
        }
        [HttpDelete("{roleId}")]
        public async Task<IActionResult> DeleteSport( string roleId)
        {
            await _roleRepo.DeleteRoleAsync(roleId);
            return Ok();
        }
    }
}
