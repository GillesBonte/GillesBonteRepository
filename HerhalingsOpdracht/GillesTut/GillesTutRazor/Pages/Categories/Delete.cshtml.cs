using GillesTutRazor.Data;
using GillesTutRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GillesTutRazor.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly RazorDbContext _context;
        [BindProperty]
        public Category Category { get; set; }
        public DeleteModel(RazorDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            if (id != null || id != 0)
            {
                Category = _context.Categories.FirstOrDefault(c => c.Id == id);
            }

        }

        public IActionResult OnPost()
        {
            if (Category != null)
            {
                _context.Categories.Remove(Category);
                _context.SaveChanges();
                TempData["succes"] = "Category deleted succesfully.";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
