namespace GrantParkCoffeeShop2.Data.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public bool Featured { get; set; }
        public string Image { get; set; }
        public double Discount { get; set; }
        public bool RewardEligible { get; set; }
        public Category Category { get; set; }
    }
}