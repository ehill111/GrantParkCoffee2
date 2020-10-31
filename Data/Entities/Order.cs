using System;
using System.Collections.Generic;

namespace GrantParkCoffeeShop2.Data.Entities
{
    public class Order : EntityBase
    {
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderDetail> OrderLines { get; set; } = new List<OrderDetail>();

        //public static List<Order> Orders = new List<Order>();
    }

    public enum OrderStatus
    {
        Placed,
        Pending,
        Fulfilled
    }
}