using System.Threading.Tasks;
using Conference.Data.Models;
using Conference.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Conference.Web.Controllers
{
    [AllowAnonymous]
    public class ConferenceController: Controller
    {
        private readonly IConferenceRepository repo;

        public ConferenceController(IConferenceRepository repo)
        {
            this.repo = repo;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Organizer - Conference Overview";
            return View(await repo.GetAll());
        }

        public IActionResult Add()
        {
            ViewBag.Title = "Organizer - Add Conference";
            return View(new ConferenceModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(ConferenceModel model)
        {
            if (ModelState.IsValid)
                await repo.Add(model);

            return RedirectToAction("Index");
        }
    }
}
