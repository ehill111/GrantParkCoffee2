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

    }

}
