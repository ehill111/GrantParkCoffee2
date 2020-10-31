using GrantParkCoffeeShop2.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        //public DbSet<ProductSalesHistory> ProductSalesHistories { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        //public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Item> Items { get; set; }
        //public DbSet<FeatureOfDay> FeaturesOfDay { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        //public object Product { get; internal set; }
        //public object Owner { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(e => e.Category)
                .IsRequired();

            builder.Entity<Customer>()
                .HasOne(c => c.User);

            builder.Entity<OrderDetail>()
                .HasOne(c => c.Product);

            builder.Entity<Order>()
                .HasMany(c => c.OrderLines)
                .WithOne(e => e.Order)
                .IsRequired();

            builder.Entity<ShoppingCart>()
                .HasMany(c => c.ShoppingCartItems)
                .WithOne(e => e.ShoppingCart)
                .IsRequired();

            //builder.Entity<IdentityRole>()
            //    .HasData(
            //        new IdentityRole
            //        {
            //            Name = RoleConstants.ADMIN,
            //            NormalizedName = RoleConstants.ADMIN.ToUpper()
            //        }
            //    );
            //builder.Entity<IdentityRole>()
            //    .HasData(
            //        new IdentityRole
            //        {
            //            Name = RoleConstants.USER,
            //            NormalizedName = RoleConstants.USER.ToUpper()
            //        }
            //    );

            //var food = new Category
            //{
            //    Id = 1,
            //    Name = "Food"
            //};
            //var dessert = new Category
            //{
            //    Id = 2,
            //    Name = "Dessert"
            //};
            //var beverage = new Category
            //{
            //    Id = 3,
            //    Name = "Beverage"
            //};

            //builder.Entity<Category>().HasData(food, dessert, beverage);

            //builder.Entity<Product>().HasData(

            //    new Product
            //    {
            //        Id = 1,
            //        Name = "Bacon, Egg, and Cheese Croissant",
            //        Description = "Available with pork or turkey bacon.",
            //        Image = "",
            //        UnitPrice = 6.99m,
            //        Featured = false,
            //        RewardEligible = true,
            //        Category = food,
            //        Quantity = 10
            //    },
            //       new Product
            //       {
            //           Id = 2,
            //           Name = "Chicken Salad Sandwich",
            //           Description = "Tasty chicken piled high on wheat, rye, or white bread, with lettuce and tomato.",
            //           Image = "",
            //           UnitPrice = 6.99m,
            //           Featured = true,
            //           Category = food,
            //           Quantity = 10
            //       },
            //        new Product
            //        {
            //            Id = 3,
            //            Name = "Creamy Cheese Grits",
            //            Description = "Don't get mad at Momma and Grandmama because their grits aren't as tasty as ours. They're only human!",
            //            Image = "",
            //            UnitPrice = 2.99m,
            //            Featured = false,
            //            RewardEligible = true,
            //            Category = food,
            //            Quantity = 10
            //        },
            //         new Product
            //         {
            //             Id = 4,
            //             Name = "Spinach Salad",
            //             Description = "Spinach, apples, red onion, toasted walnut halves, dried cranberries, goat cheese, and our special dressing.",
            //             Image = "",
            //             UnitPrice = 6.99m,
            //             Featured = false,
            //             RewardEligible = true,
            //             Category = food,
            //             Quantity = 10
            //         },
            //          new Product
            //          {
            //              Id = 5,
            //              Name = "Banana Nut Bread",
            //              Description = "Would you like a little warm butter on that?",
            //              Image = "",
            //              UnitPrice = 2.99m,
            //              Featured = false,
            //              RewardEligible = true,
            //              Category = dessert,
            //              Quantity = 10
            //          },
            //           new Product
            //           {
            //               Id = 6,
            //               Name = "Chocolate Chip Skone",
            //               Description = "Chocolate. Chip. Skone. What else is there to say? What? Fresh? Fresh is who we are!",
            //               Image = "",
            //               UnitPrice = 2.99m,
            //               Featured = false,
            //               RewardEligible = true,
            //               Category = dessert,
            //               Quantity = 10
            //           },
            //            new Product
            //            {
            //                Id = 7,
            //                Name = "Blueberry Muffin",
            //                Description = "Oh. My. Goodness. GOOD!",
            //                Image = "",
            //                UnitPrice = 2.99m,
            //                Featured = false,
            //                RewardEligible = true,
            //                Category = dessert,
            //                Quantity = 10
            //            },
            //             new Product
            //             {
            //                 Id = 8,
            //                 Name = "Coffee",
            //                 Description = "Every delicious cup of coffee you purchase helps support a local shelter for victims of domestic abuse.",
            //                 Image = "",
            //                 UnitPrice = 2.49m,
            //                 Featured = false,
            //                 RewardEligible = true,
            //                 Category = beverage,
            //                 Quantity = 10
            //             },
            //             new Product
            //             {
            //                 Id = 9,
            //                 Name = "Juice",
            //                 Description = "Cranberry. Orange. Apple. Just say the word.",
            //                 Image = "",
            //                 UnitPrice = 2.99m,
            //                 Featured = false,
            //                 RewardEligible = true,
            //                 Category = beverage,
            //                 Quantity = 10
            //             },
            //              new Product
            //              {
            //                  Id = 10,
            //                  Name = "Water",
            //                  Description = "Twelve ounces of life. And you can have it room temperature or cool!",
            //                  Image = "",
            //                  UnitPrice = 1.49m,
            //                  Featured = false,
            //                  RewardEligible = false,
            //                  Category = beverage,
            //                  Quantity = 10
            //              }
            //    );
        }
    }
}























