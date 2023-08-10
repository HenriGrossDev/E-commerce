using BulkyWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
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
            var objCategoryLIst = _context.Categories.ToList();
            return View(objCategoryLIst);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
