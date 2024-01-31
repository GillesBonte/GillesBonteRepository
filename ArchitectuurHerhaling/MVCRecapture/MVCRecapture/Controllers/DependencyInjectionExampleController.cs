using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCRecapture.Models;

namespace MVCRecapture.Controllers
{
    public class DependencyInjectionExampleController : Controller
    {
        // GET: DependencyInjectionExampleController
        private CounterTransient _counterTransient;
        private CounterScoped _counterScoped;
        private CounterSingleton _counterSingleton;

        public DependencyInjectionExampleController(CounterTransient counterTransient, CounterScoped counterScoped, CounterSingleton counterSingleton)
        {
            _counterTransient = counterTransient;
            _counterScoped = counterScoped;
            _counterSingleton = counterSingleton;
        }

        public ActionResult Index()
        {
            _counterScoped.Count++;
            _counterSingleton.Count++;
            _counterTransient.Count++;
            ViewBag.CounterScoped = _counterScoped.Count;
            ViewBag.CounterSingleton = _counterSingleton.Count;
            ViewBag.CounterTransient = _counterTransient.Count;
            return View();
        }
        [HttpPost]
        public IActionResult AddCounter(string test)
        {
            _counterScoped.Count++;
            _counterSingleton.Count++;
            _counterTransient.Count++;
            return RedirectToAction("Index");
        }

        // GET: DependencyInjectionExampleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DependencyInjectionExampleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DependencyInjectionExampleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: DependencyInjectionExampleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DependencyInjectionExampleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: DependencyInjectionExampleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DependencyInjectionExampleController/Delete/5
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
