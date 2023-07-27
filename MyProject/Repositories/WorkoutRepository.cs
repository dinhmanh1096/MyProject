using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyProject.Data;
using MyProject.Models;

namespace MyProject.Repositories
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private readonly MyDBContext _context;
        private readonly IMapper _mapper;

        public WorkoutRepository(MyDBContext context,IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<string> AddWorkoutAsync(WorkoutModel model)
        {
            var newWorkout = _mapper.Map<Workout>(model);
            _context.Workouts.Add(newWorkout);
            await _context.SaveChangesAsync();
            return newWorkout.WorkoutID;
        }

        public async Task DeleteWorkoutAsync(string workoutID)
        {
            var deleteWorkout = _context.Workouts.SingleOrDefault(r => r.WorkoutID == workoutID);
            if (deleteWorkout != null)
            {
                _context.Workouts.Remove(deleteWorkout);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<WorkoutModel>> GetAllWorkoutAsync()
        {
            var workouts = await _context.Workouts.ToListAsync();
            return _mapper.Map<List<WorkoutModel>>(workouts);
        }

        public async Task<WorkoutModel> GetWorkoutAsync(string workoutID)
        {
            var workout = await _context.Workouts.FindAsync(workoutID);
            return _mapper.Map<WorkoutModel>(workout);
        }

        public async Task UpdateWorkoutAsync(string workoutID, WorkoutModel model)
        {
            if (workoutID == model.WorkoutID)
            {
                var updateWorkout = _mapper.Map<Workout>(model);
                _context.Workouts!.Update(updateWorkout);
                await _context.SaveChangesAsync();
            }
        }
    }
}
