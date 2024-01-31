using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCRecapture.Models;
using MVCRecapture.Repositories;

namespace MVCRecapture.Controllers
{

    public class GameController : Controller
    {
        private GameRepo _gameRepo;
        private GenreRepo _genreRepo;

        public GameController(GameRepo gameRepo, GenreRepo genreRepo)
        {
            _gameRepo = gameRepo;
            _genreRepo = genreRepo;
        }

        // GET: GameController
        public ActionResult Index()
        {
            return View(_gameRepo.GetAll());
        }

        // GET: GameController/Details/5
        public ActionResult Details(int id)
        {
            return View(_gameRepo.GetById(id));
        }

        // GET: GameController/Create
        public ActionResult Create()
        {
            ViewBag.Genre = new SelectList(_genreRepo.GetAll(),"Name", "Name", null,"Subgenre");
            return View();
        }

        // POST: GameController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Game game)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _gameRepo.Add(game);
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Genre = new SelectList(_genreRepo.GetAll(), "Name", "Name", "Null", "Subgenre");
            return View(_gameRepo.GetById(id));
        }

        // POST: GameController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Game game)
        {
            try
            {
                _gameRepo.Update(game);
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
            _gameRepo.Delete(id);
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
