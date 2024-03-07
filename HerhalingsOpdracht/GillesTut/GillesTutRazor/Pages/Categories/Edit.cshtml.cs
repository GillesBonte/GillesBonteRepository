using GillesTutRazor.Data;
using GillesTutRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GillesTutRazor.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly RazorDbContext _context;
        [BindProperty]
        public Category? Category { get; set; }
        public EditModel(RazorDbContext context)
        {
            _context = context;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = _context.Categories.FirstOrDefault(c => c.Id == id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(Category);
                _context.SaveChanges();
                TempData["succes"] = $"Category: '{Category.Name}' updated succesfully.";
                return RedirectToPage("Index");
            }
                return Page();
        }
    }
}
