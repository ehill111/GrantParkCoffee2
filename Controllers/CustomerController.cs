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

        [HttpGet]
        public IActionResult MakeRoomReservation()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MakeRoomReservation(RoomReservation reservation)
        {
            if (reservation.Date == default) return View();

            var currentDate = new DateTime();
            var email = User.Identity.Name;
            var customer = await _context.Customers.FirstOrDefaultAsync(x => x.Email == email);
            var roomReservation = await _context.RoomReservations.Include(x => x.Customer).FirstOrDefaultAsync(x =>
            x.Customer.Email == email && x.Date >= currentDate);

            if(roomReservation != null)
            {
                ViewData["Error"] = "You have a reservation already";
                return View();
            }

            reservation.Customer = customer;
            _context.RoomReservations.Add(reservation);
            await _context.SaveChangesAsync();

            return RedirectToAction("RoomReservations");
        }
    }
}
