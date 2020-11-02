using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GrantParkCoffeeShop2.Data;
using GrantParkCoffeeShop2.Models;
using Microsoft.AspNetCore.Authorization;
using GrantParkCoffeeShop2.Data.Entities;

namespace GrantParkCoffeeShop2.Controllers
{
    [Authorize(Roles = RoleConstants.USER)]
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> RoomReservations()
        {
            var currentDate = new DateTime();
            var email = User.Identity.Name;
            var roomReservations = await _context.RoomReservations.Include(x => x.Customer)
                .Where(x => x.Customer.Email == email)
                .Select(x =>
            new RoomReservationModel
            {
                Date = x.Date.ToLongDateString(),
                Status = currentDate.Ticks > x.Date.Ticks ? "Passed" : "Current"
            }).ToListAsync();

            return View(roomReservations);
        }
    }

}
