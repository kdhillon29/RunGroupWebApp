using RunGroupWebApp.Models;

namespace RunGroupWebApp.Interfaces
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();
        Task<IEnumerable<Club>> GetCLubByCity(string city);
        Task<Club> GetByIdAsync(int id);
       // Task<Club> GetByCityAsync(int id);
        bool Add(Club club);

        bool Update(Club club);

        bool Delete(Club club);

        bool Save();
    }
}
