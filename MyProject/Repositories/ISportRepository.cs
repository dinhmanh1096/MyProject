using MyProject.Data;
using MyProject.Models;

namespace MyProject.Repositories
{
    public interface ISportRepository
    {
        public Task<List<SportModel>> GetAllSportsAsync();
        public Task<SportModel> GetSportsAsync(int sportId);
        public Task<int> AddSportAsync(RequestSportModel model);
        public Task DeleteSportAsync(int sportId);
        public Task UpdateSportAsync(int sportId, SportModel model);

        //
        List<SportModel> GetAll(string search);
    }
}
