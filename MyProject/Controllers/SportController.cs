﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Writers;
using MyProject.Data;
using MyProject.Models;
using MyProject.Repositories;

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportController : ControllerBase
    {
        private readonly ISportRepository _sportRepo;

        public SportController(ISportRepository repo)
        {
            _sportRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSport()
        {
            try
            {
                return Ok(await _sportRepo.GetAllSportsAsync());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{sportId}")]
        public async Task<IActionResult> GetSportByID(int sportId)
        {
            var sport = await _sportRepo.GetSportsAsync(sportId);
            return sport == null ? NotFound() : Ok(sport);
        }
        [HttpPost]
        public async Task<IActionResult> AddNewSport([FromBody] RequestSportModel model)
        {

                var newSportId = await _sportRepo.AddSportAsync(model);
                var sport = await _sportRepo.GetSportsAsync(newSportId);
                return sport == null ? BadRequest() : Ok(sport);

        }
        [HttpPut("{sportId}")]
        public async Task<IActionResult> UpdateSport(int sportId,[FromBody] SportModel model)
        {
            if (sportId != model.SportID)
            {
                return NotFound();
            }
            await _sportRepo.UpdateSportAsync(sportId, model);
            return Ok();
        }
        [HttpDelete("{sportId}")]
        public async Task<IActionResult> DeleteSport([FromRoute] int sportId)
        {
            var sport = await _sportRepo.GetSportsAsync(sportId);
            if (sport == null)
                return NotFound();
            await _sportRepo.DeleteSportAsync(sportId);
            return Ok();
        }

        
    }
}
