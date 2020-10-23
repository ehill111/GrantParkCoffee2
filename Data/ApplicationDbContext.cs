using System;
using System.Collections.Generic;
using System.Text;
using GrantParkCoffeeShop2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GrantParkCoffeeShop2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public object modelBuilder;
        internal List<Product> products;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSalesHistory> ProductSalesHistories { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public object Product { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    }
                );
            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Name = "Customer",
                        NormalizedName = "CUSTOMER"
                    }
                );
            builder.Entity<IdentityRole>()
               .HasData(
                   new IdentityRole
                   {
                       Name = "Owner",
                       NormalizedName = "OWNER"
                   }
               );

            builder.Entity<Category>().HasData(
                 new Category
                 {
                     CategoryID = 1,
                     CategoryName = "Food"
                 },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Dessert"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Beverage"
                }
                );

            builder.Entity<Product>().HasData(
                    new Product
                    {
                        ProductId = 1,
                        ProductType = "Food",
                        ProductName = "Bacon, Egg, and Cheese Croissant",
                        Description = "Available with pork or turkey bacon.",
                        ImagePath = "",
                        UnitPrice = 6.99,
                        ProductFeatured = false,
                        ProductOnSale = false,
                        RewardEligible = true,
                        CategoryID = 1
                    },
                   new Product
                   {
                       ProductId = 2,
                       ProductType = "Food",
                       ProductName = "Chicken Salad Sandwich",
                       Description = "Tasty chicken piled high on wheat, rye, or white bread, with lettuce and tomato.",
                       ImagePath = "",
                       UnitPrice = 6.99,
                       ProductFeatured = true,
                       ProductOnSale = false,
                       RewardEligible = true,
                       CategoryID = 1
                   },
                    new Product
                    {
                        ProductId = 3,
                        ProductType = "Food",
                        ProductName = "Creamy Cheese Grits",
                        Description = "Don't get mad at Momma and Grandmama because their grits aren't as tasty as ours. They're only human!",
                        ImagePath = "",
                        UnitPrice = 2.99,
                        ProductFeatured = false,
                        ProductOnSale = false,
                        RewardEligible = true,
                        CategoryID = 1
                    },
                     new Product
                     {
                         ProductId = 4,
                         ProductType = "Food",
                         ProductName = "Spinach Salad",
                         Description = "Spinach, apples, red onion, toasted walnut halves, dried cranberries, goat cheese, and our special dressing.",
                         ImagePath = "",
                         UnitPrice = 6.99,
                         ProductFeatured = false,
                         ProductOnSale = false,
                         RewardEligible = true,
                         CategoryID = 1
                     },
                      new Product
                      {
                          ProductId = 5,
                          ProductType = "Dessert",
                          ProductName = "Banana Nut Bread",
                          Description = "Would you like a little warm butter on that?",
                          ImagePath = "",
                          UnitPrice = 2.99,
                          ProductFeatured = false,
                          ProductOnSale = false,
                          RewardEligible = true,
                          CategoryID = 2
                      },
                       new Product
                       {
                           ProductId = 6,
                           ProductType = "Dessert",
                           ProductName = "Chocolate Chip Skone",
                           Description = "Chocolate. Chip. Skone. What else is there to say? What? Fresh? Fresh is who we are!",
                           ImagePath = "",
                           UnitPrice = 2.99,
                           ProductFeatured = false,
                           ProductOnSale = false,
                           RewardEligible = true,
                           CategoryID = 2
                       },
                        new Product
                        {
                            ProductId = 7,
                            ProductType = "Dessert",
                            ProductName = "Blueberry Muffin",
                            Description = "Oh. My. Goodness. GOOD!",
                            ImagePath = "",
                            UnitPrice = 2.99,
                            ProductFeatured = false,
                            ProductOnSale = false,
                            RewardEligible = true,
                            CategoryID = 2
                        },
                         new Product
                         {
                             ProductId = 8,
                             ProductType = "Beverage",
                             ProductName = "Coffee",
                             Description = "Every delicious cup of coffee you purchase helps support a local shelter for victims of domestic abuse.",
                             ImagePath = "",
                             UnitPrice = 2.49,
                             ProductFeatured = false,
                             ProductOnSale = false,
                             RewardEligible = true,
                             CategoryID = 3
                         },
                         new Product
                         {
                             ProductId = 9,
                             ProductType = "Beverage",
                             ProductName = "Juice",
                             Description = "Cranberry. Orange. Apple. Just say the word.",
                             ImagePath = "",
                             UnitPrice = 2.99,
                             ProductFeatured = false,
                             ProductOnSale = false,
                             RewardEligible = true,
                             CategoryID = 3
                         },
                          new Product
                          {
                              ProductId = 10,
                              ProductType = "Beverage",
                              ProductName = "Water",
                              Description = "Twelve ounces of life. And you can have it room temperature or cool!",
                              ImagePath = "",
                              UnitPrice = 1.49,
                              ProductFeatured = false,
                              ProductOnSale = false,
                              RewardEligible = false,
                              CategoryID = 3
                          }
                    );

        }

        public DbSet<GrantParkCoffeeShop2.Models.FeatureOfDay> FeatureOfDay { get; set; }

        public DbSet<GrantParkCoffeeShop2.Models.Owner> Owner { get; set; }

    }

}























