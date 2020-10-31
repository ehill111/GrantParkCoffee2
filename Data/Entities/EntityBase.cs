using System.ComponentModel.DataAnnotations.Schema;

namespace GrantParkCoffeeShop2.Data.Entities
{
    public abstract class EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}