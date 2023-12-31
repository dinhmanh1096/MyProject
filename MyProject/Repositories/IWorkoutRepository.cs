﻿using MyProject.Models;

namespace MyProject.Repositories
{
    public interface IWorkoutRepository
    {
        public Task<List<WorkoutModel>> GetAllWorkoutAsync();
        public Task<WorkoutModel> GetWorkoutAsync(int workoutID);
        public Task<int> AddWorkoutAsync(RequestWorkoutModel model);
        public Task UpdateWorkoutAsync(int workoutID, WorkoutModel model);
        public Task DeleteWorkoutAsync(int workoutID);
    }
}
