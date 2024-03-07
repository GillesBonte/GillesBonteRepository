using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UZSyntra.Libraries.Interfaces;
using UZSyntra.Data.Models;
using UZSyntra.Libraries.Services;
using UZSyntra.Libraries.ViewModels;

namespace UZSyntra.WebClient.Controllers
{
   
    public class DepartmentsController : Controller
    {
        private DepartmentService _depService;

        public DepartmentsController(DepartmentService depService)
        {
            _depService = depService;
        }

        // GET: DepartmentsController
        public ActionResult Index()
        {
            return View(_depService.GetAll());
        }

        // GET: DepartmentsController/Details/5
        public ActionResult Details(int id)
        {
            return View(_depService.GetById(id));
        }

        // GET: DepartmentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DepartmentViewModel entity)
        {
            try
            {
                _depService.Add(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentsController/Edit/5
        public ActionResult Edit(int id)
        {

            return View(_depService.GetById(id));
        }

        // POST: DepartmentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DepartmentViewModel department)
        {
            try
            {
                _depService.Update(department);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentsController/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View();
        }

        // POST: DepartmentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(DepartmentViewModel department)
        {
            try
            {
                _depService.Delete(department.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
