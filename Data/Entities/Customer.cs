namespace GrantParkCoffeeShop2.Data.Entities
{
    public class Customer : EntityBase
    {
        public int RewardPointsBalance { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
    }
}