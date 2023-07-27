using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyProject.Data;
using MyProject.Models;

namespace MyProject.Repositories
{
    public class SportRepository : ISportRepository
    {
        private readonly MyDBContext _context;
        private readonly IMapper _mapper;

        public SportRepository(MyDBContext context,IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<string> AddSportAsync(SportModel model)
        {
            var newSport= _mapper.Map<Sport>(model);
            _context.Sports.Add(newSport);
            await _context.SaveChangesAsync();
            return newSport.SportID;
        }

        public async Task DeleteSportAsync(string sportId)
        {
            var deleteSport = _context.Sports.SingleOrDefault(s=>s.SportID==sportId);
            if(deleteSport!=null)
            {
                _context.Sports.Remove(deleteSport);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<SportModel>> GetAllSportsAsync()
        {
            var sports = await _context.Sports.ToListAsync();
            return _mapper.Map<List<SportModel>>(sports);
        }

        public async Task<SportModel> GetSportsAsync(string sportId)
        {
            var sport = await _context.Sports!.FindAsync(sportId);
            return _mapper.Map<SportModel>(sport);
        }

        public async Task UpdateSportAsync(string sportId, SportModel sport)
        {
            if(sportId==sport.SportID)
            {
                var updateSport = _mapper.Map<Sport>(sport);
                _context.Sports.Update(updateSport);
                await _context.SaveChangesAsync();
            }
        }
    }
}
