using System;

namespace GrantParkCoffeeShop2.Data.Entities
{
    public class OrderDetail : EntityBase
    {
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}