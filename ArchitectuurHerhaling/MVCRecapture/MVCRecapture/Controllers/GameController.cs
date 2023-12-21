using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCRecapture.Models;

namespace MVCRecapture.Controllers
{
    public class GameController : Controller
    {
        // GET: GameController
        public ActionResult Index()
        {
            Models.GameRepo gameRepo = new Models.GameRepo();
            return View(gameRepo.GetAll());
        }

        // GET: GameController/Details/5
        public ActionResult Details(int id)
        {
            GameRepo gameRepo = new GameRepo();
            return View(gameRepo.GetById(id));
        }

        // GET: GameController/Create
        public ActionResult Create()
        {
            GenreRepo genreRepo = new GenreRepo();
            ViewBag.Genre = new SelectList(genreRepo.GetAll(),"Name", "Name", null,"Subgenre");
            return View();
        }

        // POST: GameController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Game game)
        {
            try
            {
                Globals._games.Add(game);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController/Edit/5
        public ActionResult Edit(int id)
        {
            GameRepo gameRepo = new GameRepo();
            GenreRepo genreRepo = new GenreRepo();

            ViewBag.Genre = new SelectList(genreRepo.GetAll(), "Name", "Name", "Null", "Subgenre");
            return View(gameRepo.GetById(id));
        }

        // POST: GameController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Game game)
        {
            try
            {
                GameRepo gameRepo = new GameRepo();
                gameRepo.Update(game);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController/Delete/5
        public ActionResult Delete(int id)
        {
            GameRepo gameRepo = new GameRepo();
            gameRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: GameController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
