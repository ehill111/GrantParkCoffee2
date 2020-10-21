using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int CartItemId { get; set; }
       
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }

    //When Customer adda a product to their Cart, they are creating a new entry in this table
    //When a Customer chooses to purchase their cart, you find all items from this table with
    //the CustomerID that matches the curretn customer
}
