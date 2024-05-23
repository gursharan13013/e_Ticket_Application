using e_Ticket_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace e_Ticket_Application.Data.Services
{
    public class ActorService : IActorServices
    {
        private readonly AppDBContext _dbContext;

        public ActorService(AppDBContext Context) => _dbContext = Context;

        public async Task Add(Actor actor)
        {
            await _dbContext.Actors.AddAsync(actor);
            _dbContext.SaveChanges();
        }

        public async Task Delete(int id)
        {
            Actor actor = await _dbContext.Actors.SingleOrDefaultAsync(a => a.Id == id);
            _dbContext.Actors.Remove(actor);    
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Actor> GetById(int id)
        {
            Actor actor = await _dbContext.Actors.SingleOrDefaultAsync(a => a.Id == id);
            return actor;   
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var actors = await _dbContext.Actors.ToListAsync();
            return actors;

        }

        public async Task<Actor> Update(int id, Actor NewActor)
        {
            _dbContext.Update(NewActor);
            await _dbContext.SaveChangesAsync();
            return NewActor;
        }
    }
}
