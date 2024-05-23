using e_Ticket_Application.Data;
using e_Ticket_Application.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_Ticket_Application.Controllers
{ 
    public class ProducerController : Controller
    {
        //private readonly AppDBContext _dbContext;
        private readonly IProducerServices _Service;

        public ProducerController(IProducerServices Service)
        {
            _Service = Service;
        }
        public async Task<IActionResult> Index()
        {
            var Data = await _Service.GetAll();
            return View(Data);
        }
    }
}
