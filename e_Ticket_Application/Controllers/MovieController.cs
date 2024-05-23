using e_Ticket_Application.Data;
using e_Ticket_Application.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_Ticket_Application.Controllers
{
    public class MovieController : Controller
    {
        //private readonly AppDBContext _dbContext;
        private readonly IMovieServices _Services;

        public MovieController(IMovieServices services)
        {
            _Services = services;
        }
        public async Task<IActionResult> Index()
        {
            var Data = await _Services.GetAll();
            return View(Data);
        }
    }
}
