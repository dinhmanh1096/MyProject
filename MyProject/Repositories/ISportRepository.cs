using MyProject.Data;
using MyProject.Models;

namespace MyProject.Repositories
{
    public interface ISportRepository
    {
        public Task<List<SportModel>> GetAllSportsAsync();
        public Task<SportModel> GetSportsAsync(string sportId);
        public Task<string> AddSportAsync(SportModel model);
        public Task DeleteSportAsync(string sportId);
        public Task UpdateSportAsync(string sportId, SportModel model);
    }
}
