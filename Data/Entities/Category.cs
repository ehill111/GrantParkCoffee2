using System.Collections.Generic;

namespace GrantParkCoffeeShop2.Data.Entities
{
    public class Category : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();

        //public static List<Category> Categories()
        //{
        //    var categories = new List<Category>
        //    {
        //        new Category
        //        {
        //            Id = 1,
        //            Name = "Food"
        //        },
        //        new Category
        //        {
        //            Id = 2,
        //            Name = "Dessert"
        //        },
        //        new Category
        //        {
        //            Id = 3,
        //            Name = "Beverage"
        //        }
        //    };

        //    return categories;
        //}
    }
}