using System;

namespace GrantParkCoffeeShop2.Data.Entities
{
    public class ShoppingCartItem : EntityBase
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}