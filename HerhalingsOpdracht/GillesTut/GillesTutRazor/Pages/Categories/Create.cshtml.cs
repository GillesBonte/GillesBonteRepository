using GillesTutRazor.Data;
using GillesTutRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GillesTutRazor.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly RazorDbContext _context;
        [BindProperty] //<-- needed to bind Category to post action
        public Category Category { get; set; }

        public CreateModel(RazorDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            _context.Categories.Add(Category);
            _context.SaveChanges();
            TempData["succes"] = "Category created succesfully.";
            return RedirectToPage("Index");
        }
    }
}
