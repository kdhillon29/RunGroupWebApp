﻿using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Data;
using RunGroupWebApp.Interfaces;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Repository
{
    public class RaceRepository : IRaceRepository
    {
        private readonly ApplicationDbContext _context;

        public RaceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Race race)
        {
             _context.Races.Add(race);  
            return Save();

        }

        public bool Delete(Race race)
        {
            _context.Races.Remove(race);
            return Save();
        }

        public async Task<IEnumerable<Race>> GetAll()
        {
            return await _context.Races.ToListAsync();
        }

        public async Task<IEnumerable<Race>> GetAllRacesByCity(string city)
        {
            return await _context.Races.Where(r => r.Address.City.Contains(city)).ToListAsync();
        }


        public bool Update(Race race)
        {
           _context.Races.Update(race);
            return Save();
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public async Task<Race> GetByIdAsync(int id)
        {
            return await _context.Races.Include(c => c.Address).FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
