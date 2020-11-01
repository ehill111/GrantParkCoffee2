using System;

namespace GrantParkCoffeeShop2.Data.Entities
{
    public class RoomReservation : EntityBase
    {
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
    }
}
