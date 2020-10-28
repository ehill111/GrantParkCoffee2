using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GrantParkCoffeeShop2.Data;
using GrantParkCoffeeShop2.Models;
using System.Security.Claims;

namespace GrantParkCoffeeShop2.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;//This may be unnecessary since I'm rebuilding controller from scratch, but will test.
        private readonly ShoppingCart shoppingCart;
        public ShoppingCartController()
        {

        }
        public ShoppingCartController(ApplicationDbContext context)//This may be unnecessary since I'm rebuilding controller from scratch.
        {
            _context = context;
        }

        // GET: Controller
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
