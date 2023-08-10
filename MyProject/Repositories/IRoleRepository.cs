﻿using MyProject.Models;

namespace MyProject.Repositories
{
    public interface IRoleRepository
    {
        public Task<List<RoleModel>> GetAllRoleAsync();
        public Task<RoleModel> GetRoleAsync(int roleId);
        public Task<int> AddRoleAsync(RequestRoleModel model);
        public Task DeleteRoleAsync (int roleId);
        public Task UpdateRoleAsync (int roleId,RoleModel model);
    }
}
