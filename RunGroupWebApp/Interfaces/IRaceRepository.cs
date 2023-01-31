using RunGroupWebApp.Models;

namespace RunGroupWebApp.Interfaces
{
    public interface IRaceRepository
    {
        Task<IEnumerable<Race>> GetAll();
        Task<IEnumerable<Race>> GetAllRacesByCity(string city);
       
        Task<Race> GetByIdAsync(int id);
        Task<Race?> GetByIdAsyncNoTracking(int id);
        // Task<Club> GetByCityAsync(int id);
        bool Add(Race race);

        bool Update(Race race);
        bool Delete(Race race);
        bool Save();
    }
}
