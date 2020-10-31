using GrantParkCoffeeShop2.Data;
using GrantParkCoffeeShop2.Data.Entities;
using GrantParkCoffeeShop2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Controllers
{
    [Authorize(Roles = RoleConstants.USER)]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(x => x.Email == HttpContext.User.Identity.Name);
            var orders = await _context.Orders.Include(x => x.Customer)
                .Include(x => x.OrderLines)
                .ThenInclude(x => x.Product).Where(x => x.Customer.Email == customer.Email).ToListAsync();
            return View(orders);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var order = await _context.Orders.Include(x => x.Customer).Include(x => x.OrderLines).ThenInclude(x => x.Product).FirstOrDefaultAsync(x => x.Id == id);
            
            return View(order);
        }

        public async Task<RedirectToActionResult> Increment(int orderId, int orderLineId)
        {
            var order = await _context.Orders.Include(x => x.OrderLines).FirstOrDefaultAsync(x => x.Id == orderId);
            var orderLine = order.OrderLines.FirstOrDefault(x => x.Id == orderLineId);
            orderLine.Quantity++;

            _context.Update(order);
            await _context.SaveChangesAsync();

            return RedirectToAction("Edit", new { id = orderId });
        }

        public async Task<RedirectToActionResult> Decrement(int orderId, int orderLineId)
        {
            var order = await _context.Orders.Include(x => x.OrderLines).FirstOrDefaultAsync(x => x.Id == orderId);
            var orderLine = order.OrderLines.FirstOrDefault(x => x.Id == orderLineId);
            if (orderLine.Quantity > 1)
            {
                orderLine.Quantity--;

                _context.Update(order);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Edit", new { id = orderId });
        }
    }
}
