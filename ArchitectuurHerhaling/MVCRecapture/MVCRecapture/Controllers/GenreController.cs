using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCRecapture.Models;
using MVCRecapture.Repositories;

namespace MVCRecapture.Controllers
{
    public class GenreController : Controller
    {

        private GenreRepo _genreRepo;
        private SubgenreRepo _subgenreRepo;

        public GenreController(GenreRepo genreRepo, SubgenreRepo subgenRepo)
        {
            _genreRepo = genreRepo;
            _subgenreRepo = subgenRepo;
        }


        // GET: GenreController
        public ActionResult Index()
        {
            return View(_genreRepo.GetAll());
        }

        // GET: GenreController/Details/5
        public ActionResult Details(string name)
        {
        
            return View(_genreRepo.GetByName(name));
        }

        // GET: GenreController/Create
        public ActionResult Create()
        {

            ViewBag.Subgenre = new SelectList(_subgenreRepo.GetAll(), "Name", "Name", "Null", "Name");

            return View();
        }

        // POST: GenreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genre)
        {
            try
            {
                _genreRepo.Add(genre);
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
            ViewBag.Subgenre = new SelectList(_subgenreRepo.GetAll(), "Name", "Name", "Null", "Name");
            return View(_genreRepo.GetByName(name));
        }

        // POST: GenreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Genre genre)
        {
            try
            {
                _genreRepo.Update(genre);

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
            _genreRepo.Delete(name);
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
