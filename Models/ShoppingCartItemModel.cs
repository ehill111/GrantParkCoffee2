using GrantParkCoffeeShop2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Models
{
    public class ShoppingCartItemModel
    {
        public ShoppingCartItemModel()
        {
            //UniqueId = Guid.NewGuid().ToString();
        }

        public int Id { get; set; }
        public string UniqueId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        public double SubTotal
        {
            get
            {
                return Quantity * Product.UnitPrice;
            }
        }
    }
}
