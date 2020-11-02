using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GrantParkCoffeeShop2.Data;
using GrantParkCoffeeShop2.Models;
using GrantParkCoffeeShop2.Data.Entities;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ViewResult Index()
        {
            var cart = HttpContext.Session.Get<ShoppingCartModel>("Cart");
            cart ??= new ShoppingCartModel();
            ViewData["Error"] = TempData["Error"];
            return View(cart);
        }

        public async Task<RedirectToActionResult> Cart(int id)
        {
            var selectedProduct = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (selectedProduct != null)
            {
                var cart = HttpContext.Session.Get<ShoppingCartModel>("Cart");
                cart ??= new ShoppingCartModel();
                cart.ShoppingCartItems.Add(new ShoppingCartItemModel
                {
                    Product = selectedProduct,
                    Quantity = 1,
                    UniqueId = Guid.NewGuid().ToString()
                });

                HttpContext.Session.Set("Cart", cart);
                HttpContext.Session.SetInt32("CartCount", cart.ShoppingCartItems.Count);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Remove(string id)
        {
            var cart = HttpContext.Session.Get<ShoppingCartModel>("Cart");
            cart ??= new ShoppingCartModel();

            var product = cart.ShoppingCartItems.FirstOrDefault(x => x.UniqueId == id);
            cart.ShoppingCartItems.Remove(product);
            HttpContext.Session.Set("Cart", cart);
            HttpContext.Session.SetInt32("CartCount", cart.ShoppingCartItems.Count);

            return RedirectToAction("Index");
        }

        public RedirectToActionResult Increment(string id)
        {
            var cart = HttpContext.Session.Get<ShoppingCartModel>("Cart");
            cart ??= new ShoppingCartModel();

            var shoppingcartItem = cart.ShoppingCartItems.FirstOrDefault(x => x.UniqueId == id);
            shoppingcartItem.Quantity++;

            if(shoppingcartItem.Product.Quantity < shoppingcartItem.Quantity)
            {
                TempData["Error"] = "Out of stock";
                return RedirectToAction("Index");
            }

            HttpContext.Session.Set("Cart", cart);

            return RedirectToAction("Index");
        }

        public RedirectToActionResult Decrement(string id)
        {
            var cart = HttpContext.Session.Get<ShoppingCartModel>("Cart");
            cart ??= new ShoppingCartModel();

            var shoppingcartItem = cart.ShoppingCartItems.FirstOrDefault(x => x.UniqueId == id);
            if (shoppingcartItem.Quantity > 1)
            {
                shoppingcartItem.Quantity--;
                HttpContext.Session.Set("Cart", cart);
            }

            return RedirectToAction("Index");
        }


        [Authorize(Roles = RoleConstants.USER)]
        public async Task<IActionResult> Checkout()
        {
            var email = HttpContext.User.Identity.Name;
            var customer = _context.Customers.Include(x => x.User).FirstOrDefault(x => x.Email == email);
            var order = new Order
            {
                Customer = customer,
                Date = DateTime.Now,
                OrderNumber = Guid.NewGuid().ToString(),
                Status = OrderStatus.Placed
            };

            var cart = HttpContext.Session.Get<ShoppingCartModel>("Cart");
            cart ??= new ShoppingCartModel();

            for (int i = 0; i < cart.ShoppingCartItems.Count; i++)
            {
                var line = cart.ShoppingCartItems[i];
                var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == line.Product.Id);
                var orderDetail = new OrderDetail
                {
                    Order = order,
                    Product = product,
                    Quantity = line.Quantity,
                    UnitPrice = line.Product.UnitPrice
                };

                order.OrderLines.Add(orderDetail);
                
                if(product.Quantity - orderDetail.Quantity < 0)
                {
                    TempData["Error"] = $"{product.Name} has {product.Quantity} in stock";
                    return RedirectToAction("Index");
                }

                product.Quantity -= orderDetail.Quantity;
            }

            customer.RewardPointsBalance++;
            _context.Update(customer);

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            HttpContext.Session.Remove("Cart");
            HttpContext.Session.Remove("CartCount");
            HttpContext.Session.SetInt32("RewardPoints", customer.RewardPointsBalance);

            return RedirectToAction("Index");
        }
    }
}
