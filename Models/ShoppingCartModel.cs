using GrantParkCoffeeShop2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Models
{
    public class ShoppingCartModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public IList<ShoppingCartItemModel> ShoppingCartItems { get; set; } = new List<ShoppingCartItemModel>();

        public double TotalAmount
        {
            get
            {
                return ShoppingCartItems.Sum(x => x.SubTotal);
            }
        }
    }
}
