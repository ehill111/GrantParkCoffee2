﻿// <auto-generated />
using System;
using GrantParkCoffeeShop2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GrantParkCoffeeShop2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Food"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Dessert"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Beverage"
                        });
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RewardPointsBalance")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.FeatureOfDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FeaturedProduct")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FeatureOfDay");
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<double>("OrderAmountTotal")
                        .HasColumnType("float");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("OrderFulfilled")
                        .HasColumnType("bit");

                    b.Property<string>("OrderInstructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OrderPending")
                        .HasColumnType("bit");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProductSalesHistoryId")
                        .HasColumnType("int");

                    b.HasKey("OwnerId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("IdentityUserId");

                    b.HasIndex("ProductSalesHistoryId");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ProductFeatured")
                        .HasColumnType("bit");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ProductOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("ProductType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RewardEligible")
                        .HasColumnType("bit");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryID = 1,
                            Description = "Available with pork or turkey bacon.",
                            ImagePath = "",
                            ProductFeatured = false,
                            ProductName = "Bacon, Egg, and Cheese Croissant",
                            ProductOnSale = false,
                            ProductType = "Food",
                            RewardEligible = true,
                            UnitPrice = 6.9900000000000002
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryID = 1,
                            Description = "Tasty chicken piled high on wheat, rye, or white bread, with lettuce and tomato.",
                            ImagePath = "",
                            ProductFeatured = true,
                            ProductName = "Chicken Salad Sandwich",
                            ProductOnSale = false,
                            ProductType = "Food",
                            RewardEligible = true,
                            UnitPrice = 6.9900000000000002
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryID = 1,
                            Description = "Don't get mad at Momma and Grandmama because their grits aren't as tasty as ours. They're only human!",
                            ImagePath = "",
                            ProductFeatured = false,
                            ProductName = "Creamy Cheese Grits",
                            ProductOnSale = false,
                            ProductType = "Food",
                            RewardEligible = true,
                            UnitPrice = 2.9900000000000002
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryID = 1,
                            Description = "Spinach, apples, red onion, toasted walnut halves, dried cranberries, goat cheese, and our special dressing.",
                            ImagePath = "",
                            ProductFeatured = false,
                            ProductName = "Spinach Salad",
                            ProductOnSale = false,
                            ProductType = "Food",
                            RewardEligible = true,
                            UnitPrice = 6.9900000000000002
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryID = 2,
                            Description = "Would you like a little warm butter on that?",
                            ImagePath = "",
                            ProductFeatured = false,
                            ProductName = "Banana Nut Bread",
                            ProductOnSale = false,
                            ProductType = "Dessert",
                            RewardEligible = true,
                            UnitPrice = 2.9900000000000002
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryID = 2,
                            Description = "Chocolate. Chip. Skone. What else is there to say? What? Fresh? Fresh is who we are!",
                            ImagePath = "",
                            ProductFeatured = false,
                            ProductName = "Chocolate Chip Skone",
                            ProductOnSale = false,
                            ProductType = "Dessert",
                            RewardEligible = true,
                            UnitPrice = 2.9900000000000002
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryID = 2,
                            Description = "Oh. My. Goodness. GOOD!",
                            ImagePath = "",
                            ProductFeatured = false,
                            ProductName = "Blueberry Muffin",
                            ProductOnSale = false,
                            ProductType = "Dessert",
                            RewardEligible = true,
                            UnitPrice = 2.9900000000000002
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryID = 3,
                            Description = "Every delicious cup of coffee you purchase helps support a local shelter for victims of domestic abuse.",
                            ImagePath = "",
                            ProductFeatured = false,
                            ProductName = "Coffee",
                            ProductOnSale = false,
                            ProductType = "Beverage",
                            RewardEligible = true,
                            UnitPrice = 2.4900000000000002
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryID = 3,
                            Description = "Cranberry. Orange. Apple. Just say the word.",
                            ImagePath = "",
                            ProductFeatured = false,
                            ProductName = "Juice",
                            ProductOnSale = false,
                            ProductType = "Beverage",
                            RewardEligible = true,
                            UnitPrice = 2.9900000000000002
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryID = 3,
                            Description = "Twelve ounces of life. And you can have it room temperature or cool!",
                            ImagePath = "",
                            ProductFeatured = false,
                            ProductName = "Water",
                            ProductOnSale = false,
                            ProductType = "Beverage",
                            RewardEligible = false,
                            UnitPrice = 1.49
                        });
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.ProductSalesHistory", b =>
                {
                    b.Property<int>("ProductSalesHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductSalesHistoryId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductSalesHistories");
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.RoomReservation", b =>
                {
                    b.Property<int>("RoomReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("ReservationCustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReservationStartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReservationStopDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReservationTimeStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReservationTimeStop")
                        .HasColumnType("datetime2");

                    b.HasKey("RoomReservationId");

                    b.HasIndex("CustomerId");

                    b.ToTable("RoomReservations");
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "c2e67dc2-712b-49b9-ba20-a0dc88e8a69d",
                            ConcurrencyStamp = "1673649d-b92d-4278-9c82-d833c5649a59",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "f3572fbd-5c78-4626-bc84-f21689d0b1ed",
                            ConcurrencyStamp = "d001e325-136f-4984-8215-87d8a65afc28",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "3255e54a-b790-46bd-b333-a5a40c98263b",
                            ConcurrencyStamp = "ccbe2ca5-0cf2-4e77-93f8-4a0d7f432b4e",
                            Name = "Owner",
                            NormalizedName = "OWNER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.Customer", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.Item", b =>
                {
                    b.HasOne("GrantParkCoffeeShop2.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.Order", b =>
                {
                    b.HasOne("GrantParkCoffeeShop2.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.Owner", b =>
                {
                    b.HasOne("GrantParkCoffeeShop2.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.HasOne("GrantParkCoffeeShop2.Models.ProductSalesHistory", "ProductSalesHistory")
                        .WithMany()
                        .HasForeignKey("ProductSalesHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.Product", b =>
                {
                    b.HasOne("GrantParkCoffeeShop2.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID");
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.ProductSalesHistory", b =>
                {
                    b.HasOne("GrantParkCoffeeShop2.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GrantParkCoffeeShop2.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.RoomReservation", b =>
                {
                    b.HasOne("GrantParkCoffeeShop2.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GrantParkCoffeeShop2.Models.ShoppingCart", b =>
                {
                    b.HasOne("GrantParkCoffeeShop2.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GrantParkCoffeeShop2.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
