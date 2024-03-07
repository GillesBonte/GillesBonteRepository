using GillesTut.DataAccess.Data;
using GillesTut.Models;
using Microsoft.AspNetCore.Mvc;

namespace GillesTutWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            //if (category.Name == category.DisplayOrder.ToString()) 
            //{
            //    ModelState.AddModelError("name", "The Display Order cannot exactly match the Name."); //key ("name") adds the error to the specific input
            //}
            //if (category.Name.ToLower() == "test")
            //{
            //    ModelState.AddModelError("", "Test is an invalid value."); //no key ("") adds the error only to the summary
            //}
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                TempData["succes"] = "Category created succesfully.";
                return RedirectToAction("Index");
            }
        return View();
        }



        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _context.Categories.Find(id);
            //Category? categoryFromDb2 = _context.Categories.FirstOrDefault(u =>u.Id==id);
            //Category? categoryFromDb3 = _context.Categories.Where(u=>u.Id==id).FirstOrDefault();
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(category);
                _context.SaveChanges();
                TempData["succes"] = "Category updated succesfully.";
                return RedirectToAction("Index");
            }
            return View();
        }



        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _context.Categories.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {

            Category? categoryToDelete = _context.Categories.Find(id);
            if(categoryToDelete == null) 
            {
                return NotFound();
            }
            _context.Categories.Remove(categoryToDelete);
            _context.SaveChanges();
            TempData["succes"] = "Category deleted succesfully.";
            return RedirectToAction("Index");
        }


    }
}
