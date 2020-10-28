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
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        // GET: Controller
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();//Method to get shopping cart items to view.
            _shoppingCart.ShoppingCartItems = items;

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            }

            

        }

    }
}
