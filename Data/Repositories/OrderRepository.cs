using GrantParkCoffeeShop2.Data.Interfaces;
using GrantParkCoffeeShop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(ApplicationDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _appDbContext.Orders.Add(order);
        }
    }
}
