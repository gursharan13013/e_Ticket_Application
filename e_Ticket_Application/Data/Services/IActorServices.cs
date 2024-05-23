using e_Ticket_Application.Models;

namespace e_Ticket_Application.Data.Services
{
    public interface IActorServices
    {
        Task<IEnumerable<Actor>> GetAll();
        Task<Actor> GetById(int id);
        Task Add(Actor actor);

        Task<Actor> Update(int id, Actor actor);
        Task Delete(int id);

    }
}
