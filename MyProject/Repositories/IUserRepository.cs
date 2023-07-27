using MyProject.Models;

namespace MyProject.Repositories
{
    public interface IUserRepository
    {
        public Task<List<UserModel>> GetAllUserAsync();
        public Task<UserModel> GetUserAsync(string userID);
        public Task<string> AddUserAsync(UserModel model);
        public Task UpdateUserAsync(string userID, UserModel model);
        public Task DeleteUserAsync(string userID);
    }
}
