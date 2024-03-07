using GillesTutRazor.Data;
using GillesTutRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GillesTutRazor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly RazorDbContext _context;

        public IndexModel(RazorDbContext context)
        {
            _context = context;
        }

        public List<Category> CategoryList { get; set; }
        public void OnGet()
        {
            CategoryList = _context.Categories.ToList();
        }
    }
}
