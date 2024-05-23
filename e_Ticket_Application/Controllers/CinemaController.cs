using e_Ticket_Application.Data;
using e_Ticket_Application.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_Ticket_Application.Controllers
{
    public class CinemaController : Controller
    {
        //private readonly AppDBContext _dbContext;
        private readonly ICinemaServices _services;

        public CinemaController(ICinemaServices services)
        {
            _services = services;   
        }
        public async Task<IActionResult> Index()
        {
            var Data = await _services.GetAll();
            return View(Data);
        }
    }
}
