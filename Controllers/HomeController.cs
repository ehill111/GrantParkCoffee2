using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using GrantParkCoffeeShop2.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GrantParkCoffeeShop2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.Include(p => p.Category)
                .Where(x => x.Quantity > 0).ToListAsync();
            return View(products);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var product = await _context.Products.Include(p => p.Category).FirstOrDefaultAsync(x => x.Id == id);
            return View(product);
        }
    }
}
