using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products = await _context.Products
                .Include(m => m.ProductImages)
                .Take(5)
                .ToListAsync();
            BlogVM blogVM = new()
            {
                Products = products,
                Blogs = _context.Blogs.ToList()
            };

            return View(blogVM);
        }

        public IActionResult Detail(int id)
        {
            BlogDetailVM blogDetailVM = new();
            blogDetailVM.Blog = _context.Blogs
                .Include(bm=>bm.Comments)
                .FirstOrDefault(b=>b.Id==id);
            blogDetailVM.Blogs= _context.Blogs.OrderByDescending(b=>b.Id).Take(3).ToList();




            return View(blogDetailVM);
        }
    }
}
