using e_Ticket_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace e_Ticket_Application.Data.Services
{
    public class MovieServies : IMovieServices
    {
        private readonly AppDBContext _dbContext;
        public MovieServies(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            var Data = await _dbContext.Movies.ToListAsync();
            return Data;
        }

        public Movie Update(int id, Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
