using GrantParkCoffeeShop2.Data;
using GrantParkCoffeeShop2.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Controllers
{
    [Authorize(Roles = RoleConstants.ADMIN)]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Orders()
        {
            var orders = await _context.Orders.Include(x => x.Customer).ThenInclude(x => x.User).Include(x => x.OrderLines).ThenInclude(x => x.Product).ToListAsync();
            return View(orders);
        }

        public async Task<IActionResult> MonthlySalesBreakdown()
        {
            var sales = await _context.Orders.Include(x => x.OrderLines).ThenInclude(x => x.Product).ToListAsync();
            var salesByDate = sales.GroupBy(x => x.Date.Month).OrderBy(x => x.Key);
            var monthlySalesBreakdown = new List<MonthlySalesBreakdownModel>();
            foreach (var monthlySales in salesByDate)
            {
                var monthlyProductSales = new MonthlySalesBreakdownModel { Month = GetMonth(monthlySales.Key) };
                var productSales = monthlySales.SelectMany(x => x.OrderLines).GroupBy(x => x.Product.Name);
                foreach (var sale in productSales)
                {
                    var salesBreakdown = new MonthlySalesBreakdownModel.ProductSales
                    {
                        ProductName = sale.Key,
                        TotalAmount = sale.Sum(x => x.Quantity * x.UnitPrice),
                        Quantity = sale.Sum(x => x.Quantity)
                    };

                    monthlyProductSales.Sales.Add(salesBreakdown);
                }

                monthlySalesBreakdown.Add(monthlyProductSales);
            }

            ViewData["SortOrder"] = TempData["SortOrder"];

            return View(monthlySalesBreakdown);
        }

        public IActionResult ByProduct()
        {
            TempData["SortOrder"] = MonthlySalesBreakdownModel.ByProduct;
            return RedirectToAction("MonthlySalesBreakdown");
        }

        public IActionResult BySales()
        {
            TempData["SortOrder"] = MonthlySalesBreakdownModel.BySales;
            return RedirectToAction("MonthlySalesBreakdown");
        }

        private string GetMonth(int monthNum)
        {
            string month = string.Empty;
            switch (monthNum)
            {
                case 1: month = "January"; break;
                case 2: month = "February"; break;
                case 3: month = "March"; break;
                case 4: month = "April"; break;
                case 5: month = "May"; break;
                case 6: month = "June"; break;
                case 7: month = "July"; break;
                case 8: month = "August"; break;
                case 9: month = "September"; break;
                case 10: month = "October"; break;
                case 11: month = "November"; break;
                case 12: month = "December"; break;
            }

            return month;
        }
    }

    public class MonthlySalesBreakdownModel
    {
        public string Month { get; set; }
        public List<ProductSales> Sales { get; set; } = new List<ProductSales>();

        public class ProductSales
        {
            public string ProductName { get; set; }
            public double TotalAmount { get; set; }
            public int Quantity { get; set; }
        }

        public const string ByProduct = "Product";
        public const string BySales = "Sales";
    }
}