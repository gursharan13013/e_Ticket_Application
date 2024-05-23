using e_Ticket_Application.Data;
using e_Ticket_Application.Data.Services;
using e_Ticket_Application.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace e_Ticket_Application.Controllers
{
    public class ActorController : Controller
    {
        // private readonly AppDBContext _dbContext;
        private readonly IActorServices _Service;

        public ActorController(IActorServices service)
        {
            _Service = service;
        }

        public async Task<IActionResult> Index()
        {
            //var Data = await _dbContext.Actors.ToListAsync();

            var _Data = await _Service.GetAll();
            return View(_Data);

        }

        // Get/Actor/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,Bio")]Actor actor)
        {
            if (!(ModelState.IsValid))
            {
                return View(actor);
            }
            await _Service.Add(actor);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int Id = 1)
        {
            Actor actor  = await _Service.GetById(Id);
            if (actor == null) return View("NotFound");
            return View("Details",actor);
        }

        public async Task<IActionResult> Edit(int Id = 1)
        {
            Actor actor = await _Service.GetById(Id);
            if (actor == null) return View("NotFound");
            return View("Edit", actor);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, [Bind("Id,FullName,ProfilePictureUrl,Bio")] Actor actor)
        {
            if (!(ModelState.IsValid))
            {
                return View(actor);
            }
            if (Id == actor.Id)
            {
                await _Service.Update(Id, actor);
                return View("Edit", actor);
            }
            return View(actor);

        }

        public async Task<IActionResult> Delete(int Id = 1)
        {
            Actor actor = await _Service.GetById(Id);
            if (actor == null) return View("NotFound");
            return View("Delete", actor);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int Id = 1)
        {
            Actor actor = await _Service.GetById(Id);
            if (actor == null) return View("NotFound");
            await _Service.Delete(Id);
            return RedirectToAction("Index");
        }

    }
}