using e_Ticket_Application.Models;

namespace e_Ticket_Application.Data.Services
{
    public interface ICinemaServices
    {
        Task<IEnumerable<Cinema>> GetAll();
        Cinema GetById(int id);
        void Add(Cinema cinema);
        Cinema Update(int id, Cinema cinema);
        void Delete(int id);
    }
}
