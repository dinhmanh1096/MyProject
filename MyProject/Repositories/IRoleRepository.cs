using MyProject.Models;

namespace MyProject.Repositories
{
    public interface IRoleRepository
    {
        public Task<List<RoleModel>> GetAllRoleAsync();
        public Task<RoleModel> GetRoleAsync(string roleId);
        public Task<string> AddRoleAsync(RoleModel model);
        public Task DeleteRoleAsync (string roleId);
        public Task UpdateRoleAsync (string roleId,RoleModel model);
    }
}
