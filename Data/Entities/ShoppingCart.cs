using System;
using System.Collections.Generic;

namespace GrantParkCoffeeShop2.Data.Entities
{
    public class ShoppingCart : EntityBase
    {
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }

        public IList<ShoppingCartItem> ShoppingCartItems { get; set; } = new List<ShoppingCartItem>();
    }
}