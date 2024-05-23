using e_Ticket_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace e_Ticket_Application.Data.Services
{
    public class ProducerServices : IProducerServices
    {
        private readonly AppDBContext _dbContext;
        public ProducerServices(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Producer producer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Producer>> GetAll()
        {
            var Data = await _dbContext.Producers.ToListAsync();
            return Data;
        }

        public Producer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Producer Update(int id, Producer producer)
        {
            throw new NotImplementedException();
        }
    }
}
