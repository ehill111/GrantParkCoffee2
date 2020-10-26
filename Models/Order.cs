using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Display(Name = "Order Number")]
        public int OrderNumber { get; set; }
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }
        [Display(Name = "Special Instructions")]
        public string OrderInstructions { get; set; }
        [Display(Name = "Order Total")]
        public double OrderAmountTotal { get; set; }
        [Display(Name = "Order Pending")]
        public bool OrderPending { get; set; }
        [Display(Name = "Order Fulfilled")]
        public bool OrderFulfilled { get; set; }
    }
}
