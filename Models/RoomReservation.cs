using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Models
{
    public class RoomReservation
    {
        [Key]
        public int RoomReservationId { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationStopDate { get; set; }
        public DateTime ReservationTimeStart { get; set; }
        public DateTime ReservationTimeStop { get; set; }
        public string ReservationCustomerName { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
