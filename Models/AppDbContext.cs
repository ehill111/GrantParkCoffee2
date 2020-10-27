using GrantParkCoffeeShop2.Data;
using System;

namespace GrantParkCoffeeShop2.Models
{
    internal class AppDbContext
    {
        public object ShoppingCartItems { get; internal set; }

        public static implicit operator AppDbContext(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}