using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Data;
using MyProject.Models;
using MyProject.Repositories;

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private readonly IWorkoutRepository _WorkoutRepo;

        public WorkoutController(IWorkoutRepository repo)
        {
            _WorkoutRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllWorkout()
        {
            try
            {
                return Ok(await _WorkoutRepo.GetAllWorkoutAsync());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{workoutID}")]
        public async Task<IActionResult> GetWorkoutByID(string workoutID)
        {
            var workout = await _WorkoutRepo.GetWorkoutAsync(workoutID);
            return workout == null ? NotFound() : Ok(workout);
        }
        [HttpPost]
        public async Task<IActionResult> AddNewWorkout(WorkoutModel model)
        {
            try
            {
                var newWorkoutID = await _WorkoutRepo.AddWorkoutAsync(model);
                var workout = await _WorkoutRepo.GetWorkoutAsync(newWorkoutID);
                return workout == null ? NotFound() : Ok(workout);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{workoutID}")]
        public async Task<IActionResult> UpdateWorkout(string workoutID, [FromBody] WorkoutModel model)
        {
            if (workoutID != model.WorkoutID)
            {
                return NotFound();
            }
            await _WorkoutRepo.UpdateWorkoutAsync(workoutID, model);
            return Ok();
        }
        [HttpDelete("{workoutID}")]
        public async Task<IActionResult> DeleteWorkout(string workoutID)
        {
            await _WorkoutRepo.DeleteWorkoutAsync(workoutID);
            return Ok();
        }
    }
}
