using e_Ticket_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace e_Ticket_Application.Data.Services
{
    public class CinemaServices : ICinemaServices
    {
        private readonly AppDBContext _dbContext;

        public CinemaServices(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Cinema cinema)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cinema>> GetAll()
        {
            var Data = await _dbContext.Cinemas.ToListAsync();
            return Data;
        }

        public Cinema GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Cinema Update(int id, Cinema cinema)
        {
            throw new NotImplementedException();
        }
    }
}
