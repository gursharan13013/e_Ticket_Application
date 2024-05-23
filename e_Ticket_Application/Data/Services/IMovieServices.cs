using e_Ticket_Application.Models;

namespace e_Ticket_Application.Data.Services
{
    public interface IMovieServices
    {
        Task<IEnumerable<Movie>> GetAll();
        Movie GetById(int id);
        void Add(Movie movie);

        Movie Update(int id, Movie movie);
        void Delete(int id);
    }
}
