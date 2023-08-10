using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Repositories;

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISportRepository _sportRepo;

        public SearchController(ISportRepository repository) {
            _sportRepo = repository;
        }
        [HttpGet]
        public IActionResult SearchByName(string search)
        {
            try
            {
                var result = _sportRepo.GetAll(search);
                return Ok(result);
            }
            catch
            {
                return BadRequest("We can't get product.");
            }
        }
    }
}
