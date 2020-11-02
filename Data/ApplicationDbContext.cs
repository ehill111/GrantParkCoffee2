using GrantParkCoffeeShop2.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GrantParkCoffeeShop2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

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
        }
    }
}























