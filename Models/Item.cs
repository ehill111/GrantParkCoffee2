using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Models
{
    public class Item
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        //Product model deals with a particular product (i.e. "Banana Nut Bread").
        //This Item model will provide search feature for "products" in general.
    }
}
