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
        //public int CategoryId { get; set; }

        //public static System.Collections.Generic.List<Product> Products()
        //{
        //    var categories = Category.Categories();
        //    var food = categories.Find(x => x.Id == 1);
        //    var dessert = categories.Find(x => x.Id == 2);
        //    var beverage = categories.Find(x => x.Id == 3);

        //    var products = new System.Collections.Generic.List<Product>
        //    {
        //        new Product
        //            {
        //                Id = 1,
        //                Name = "Bacon, Egg, and Cheese Croissant",
        //                Description = "Available with pork or turkey bacon.",
        //                Image = "",
        //                UnitPrice = 6.99m,
        //                Featured = false,
        //                RewardEligible = true,
        //                Category = food,
        //                Quantity = 10
        //            },
        //           new Product
        //           {
        //               Id = 2,
        //               Name = "Chicken Salad Sandwich",
        //               Description = "Tasty chicken piled high on wheat, rye, or white bread, with lettuce and tomato.",
        //               Image = "",
        //               UnitPrice = 6.99m,
        //               Featured = true,
        //                RewardEligible = true,
        //               Category = food,
        //                Quantity = 10
        //           },
        //            new Product
        //            {
        //                Id = 3,
        //                Name = "Creamy Cheese Grits",
        //                Description = "Don't get mad at Momma and Grandmama because their grits aren't as tasty as ours. They're only human!",
        //                Image = "",
        //                UnitPrice = 2.99m,
        //                Featured = false,
        //                RewardEligible = true,
        //                Category = food,
        //                Quantity = 10
        //            },
        //             new Product
        //             {
        //                 Id = 4,
        //                 Name = "Spinach Salad",
        //                 Description = "Spinach, apples, red onion, toasted walnut halves, dried cranberries, goat cheese, and our special dressing.",
        //                 Image = "",
        //                 UnitPrice = 6.99m,
        //                 Featured = false,
        //                RewardEligible = true,
        //                 Category = food,
        //                Quantity = 10
        //             },
        //              new Product
        //              {
        //                  Id = 5,
        //                  Name = "Banana Nut Bread",
        //                  Description = "Would you like a little warm butter on that?",
        //                  Image = "",
        //                  UnitPrice = 2.99m,
        //                  Featured = false,
        //                RewardEligible = true,
        //                  Category = dessert,
        //                Quantity = 10
        //              },
        //               new Product
        //               {
        //                   Id = 6,
        //                   Name = "Chocolate Chip Skone",
        //                   Description = "Chocolate. Chip. Skone. What else is there to say? What? Fresh? Fresh is who we are!",
        //                   Image = "",
        //                   UnitPrice = 2.99m,
        //                   Featured = false,
        //                RewardEligible = true,
        //                   Category = dessert,
        //                Quantity = 10
        //               },
        //                new Product
        //                {
        //                    Id = 7,
        //                    Name = "Blueberry Muffin",
        //                    Description = "Oh. My. Goodness. GOOD!",
        //                    Image = "",
        //                    UnitPrice = 2.99m,
        //                    Featured = false,
        //                RewardEligible = true,
        //                    Category = dessert,
        //                Quantity = 10
        //                },
        //                 new Product
        //                 {
        //                     Id = 8,
        //                     Name = "Coffee",
        //                     Description = "Every delicious cup of coffee you purchase helps support a local shelter for victims of domestic abuse.",
        //                     Image = "",
        //                     UnitPrice = 2.49m,
        //                     Featured = false,
        //                RewardEligible = true,
        //                     Category = beverage,
        //                Quantity = 10
        //                 },
        //                 new Product
        //                 {
        //                     Id = 9,
        //                     Name = "Juice",
        //                     Description = "Cranberry. Orange. Apple. Just say the word.",
        //                     Image = "",
        //                     UnitPrice = 2.99m,
        //                     Featured = false,
        //                     RewardEligible = true,
        //                     Category = beverage,
        //                Quantity = 10
        //                 },
        //                  new Product
        //                  {
        //                      Id = 10,
        //                      Name = "Water",
        //                      Description = "Twelve ounces of life. And you can have it room temperature or cool!",
        //                      Image = "",
        //                      UnitPrice = 1.49m,
        //                      Featured = false,
        //                      RewardEligible = false,
        //                      Category = beverage,
        //                        Quantity = 10
        //                  }
        //    };

        //    return products;
        //}
    }
}