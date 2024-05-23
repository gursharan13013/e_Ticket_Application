using e_Ticket_Application.Models;

namespace e_Ticket_Application.Data.Services
{
    public interface IProducerServices
    {
        Task<IEnumerable<Producer>> GetAll();
        Producer GetById(int id);
        void Add(Producer producer);
        Producer Update(int id, Producer producer);
        void Delete(int id);
    }
}
