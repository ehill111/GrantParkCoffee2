using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using GrantParkCoffeeShop2.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using GrantParkCoffeeShop2.Data.Entities;
using System.Collections.Generic;

namespace GrantParkCoffeeShop2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            _ = services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();

            services.AddScoped<ClaimsPrincipal>(s =>
                s.GetService<IHttpContextAccessor>().HttpContext.User);
            services.AddControllers(config =>
            {
                config.Filters.Add(typeof(GlobalRouting));
            });
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped(sp => ShoppingCart.GetCart(sp));

            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, 
            UserManager<IdentityUser> userManager, 
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            SeedAdmin(userManager, roleManager);
            SeedData(context);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }

        private void SeedAdmin(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var _userManager = userManager;// app.ApplicationServices.GetRequiredService<UserManager<IdentityUser>>();
            var _roleManager = roleManager;// app.ApplicationServices.GetRequiredService<RoleManager<IdentityRole>>();

            if (!_roleManager.RoleExistsAsync(RoleConstants.ADMIN).Result)
            {
                var a = _roleManager.CreateAsync(new IdentityRole(RoleConstants.ADMIN)).Result;
            }

            if (!_roleManager.RoleExistsAsync(RoleConstants.USER).Result)
            {
                var a = _roleManager.CreateAsync(new IdentityRole(RoleConstants.USER)).Result;
            }


            var user = new User
            {
                FirstName ="Admin",
                LastName = "Admin",
                Email = "admin@admin.com",
                UserName = "admin@admin.com"
            };

            var userExist = _userManager.FindByEmailAsync("admin@admin.com").Result;
            if (userExist == null)
            {
                var result = _userManager.CreateAsync(user, "Admin@123456").Result;
                if (result.Succeeded)
                {
                    if (_roleManager.RoleExistsAsync(RoleConstants.ADMIN).Result)
                    {
                        var a = _userManager.AddToRoleAsync(user, RoleConstants.ADMIN).Result;
                    }
                }
            }
        }

        private void SeedData(ApplicationDbContext context)
        {
            if (context.Products.CountAsync().Result > 0) return;
            var food = new Category
            {
                Name = "Food"
            };
            var dessert = new Category
            {
                Name = "Dessert"
            };
            var beverage = new Category
            {
                Name = "Beverage"
            };

            context.Categories.AddRange(food, dessert, beverage);

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Bacon, Egg, and Cheese Croissant",
                    Description = "Available with pork or turkey bacon.",
                    Image = "/images/baconEggCheese.jpg",
                    UnitPrice = 6.99,
                    Featured = false,
                    RewardEligible = true,
                    Category = food,
                    Quantity = 10
                },
                   new Product
                   {
                       Name = "Chicken Salad Sandwich",
                       Description = "Tasty chicken piled high on wheat, rye, or white bread, with lettuce and tomato.",
                       Image = "/images/chickenSalad.jpg",
                       UnitPrice = 6.99,
                       Featured = true,
                       Category = food,
                       Quantity = 10
                   },
                    new Product
                    {
                        Name = "Creamy Cheese Grits",
                        Description = "Don't get mad at Momma and Grandmama because their grits aren't as tasty as ours. They're only human!",
                        Image = "/images/grits.jpg",
                        UnitPrice = 2.99,
                        Featured = false,
                        RewardEligible = true,
                        Category = food,
                        Quantity = 10
                    },
                     new Product
                     {
                         Name = "Spinach Salad",
                         Description = "Spinach, apples, red onion, toasted walnut halves, dried cranberries, goat cheese, and our special dressing.",
                         Image = "/images/salad.jpg",
                         UnitPrice = 6.99,
                         Featured = false,
                         RewardEligible = true,
                         Category = food,
                         Quantity = 10
                     },
                      new Product
                      {
                          Name = "Banana Nut Bread",
                          Description = "Would you like a little warm butter on that?",
                          Image = "/images/bananaNutBread.jpg",
                          UnitPrice = 2.99,
                          Featured = false,
                          RewardEligible = true,
                          Category = dessert,
                          Quantity = 10
                      },
                       new Product
                       {
                           Name = "Chocolate Chip Skone",
                           Description = "Chocolate. Chip. Skone. What else is there to say? What? Fresh? Fresh is who we are!",
                           Image = "/images/skone.jpg",
                           UnitPrice = 2.99,
                           Featured = false,
                           RewardEligible = true,
                           Category = dessert,
                           Quantity = 10
                       },
                        new Product
                        {
                            Name = "Blueberry Muffin",
                            Description = "Oh. My. Goodness. GOOD!",
                            Image = "/images/muffin.jpg",
                            UnitPrice = 2.99,
                            Featured = false,
                            RewardEligible = true,
                            Category = dessert,
                            Quantity = 10
                        },
                         new Product
                         {
                             Name = "Coffee",
                             Description = "Every delicious cup of coffee you purchase helps support a local shelter for victims of domestic abuse.",
                             Image = "/images/coffeeCupLogo.png",
                             UnitPrice = 2.49,
                             Featured = false,
                             RewardEligible = true,
                             Category = beverage,
                             Quantity = 10
                         },
                         new Product
                         {
                             Name = "Juice",
                             Description = "Cranberry. Orange. Apple. Just say the word.",
                             Image = "/images/juice.jpg",
                             UnitPrice = 2.99,
                             Featured = false,
                             RewardEligible = true,
                             Category = beverage,
                             Quantity = 10
                         },
                          new Product
                          {
                              Name = "Water",
                              Description = "Twelve ounces of life. And you can have it room temperature or cool!",
                              Image = "/images/water.jpg",
                              UnitPrice = 1.49,
                              Featured = false,
                              RewardEligible = false,
                              Category = beverage,
                              Quantity = 10
                          }
            };

            context.Products.AddRange(products);

            context.SaveChanges();
        }
    }
}
