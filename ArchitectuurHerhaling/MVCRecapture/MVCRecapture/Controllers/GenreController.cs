using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCRecapture.Models;

namespace MVCRecapture.Controllers
{
    public class GenreController : Controller
    {
        // GET: GenreController
        public ActionResult Index()
        {
            GenreRepo repo = new GenreRepo();
            return View(repo.GetAll());
        }

        // GET: GenreController/Details/5
        public ActionResult Details(string name)
        {
            GenreRepo repo = new GenreRepo();
            return View(repo.GetByName(name));
        }

        // GET: GenreController/Create
        public ActionResult Create()
        {
            SubgenreRepo subgenreRepo = new SubgenreRepo();

            ViewBag.Subgenre = new SelectList(subgenreRepo.GetAll(), "Name", "Name", "Null", "Name");

            return View();
        }

        // POST: GenreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genre)
        {
            try
            {
                Globals._genre.Add(genre);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreController/Edit/5
        public ActionResult Edit(string name)
        {
            GenreRepo genre = new GenreRepo();
            SubgenreRepo subgenreRepo = new SubgenreRepo();
            ViewBag.Subgenre = new SelectList(subgenreRepo.GetAll(), "Name", "Name", "Null", "Name");
            return View(genre.GetByName(name));
        }

        // POST: GenreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Genre genre)
        {
            try
            {
                GenreRepo genreRepo = new GenreRepo();
                genreRepo.Update(genre);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreController/Delete/5
        public ActionResult Delete(string name)
        {
            GenreRepo repo = new GenreRepo();
            repo.Delete(name);
            return RedirectToAction(nameof(Index));
        }

        // POST: GenreController/Delete/5
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
