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

        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

        private readonly ShoppingCart _shoppingCart;

        public object Products { get; private set; }

        public ShoppingCartController(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        // GET: Controller
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();//Method to get shopping cart items to view.
            _shoppingCart.ShoppingCartItems = items;

            var sCVM = new ShoppingCartViewModel//Need to create ViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(sCVM);

        }

        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = Products.FirstOrDefault(p => p.ProductId == productId);
            if (selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {

        }

    }
}
