using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }


        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }


        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
