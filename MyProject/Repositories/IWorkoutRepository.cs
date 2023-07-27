using MyProject.Models;

namespace MyProject.Repositories
{
    public interface IWorkoutRepository
    {
        public Task<List<WorkoutModel>> GetAllWorkoutAsync();
        public Task<WorkoutModel> GetWorkoutAsync(string workoutID);
        public Task<string> AddWorkoutAsync(WorkoutModel model);
        public Task UpdateWorkoutAsync(string workoutID,WorkoutModel model);
        public Task DeleteWorkoutAsync(string workoutID);
    }
}
