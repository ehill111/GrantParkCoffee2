//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using GrantParkCoffeeShop2.Data;
//using GrantParkCoffeeShop2.Models;
//using GrantParkCoffeeShop2.ViewsOfShop;
//using Microsoft.AspNetCore.Mvc;

//namespace GrantParkCoffeeShop2.Controllers
//{
//    public class ProductController : Controller
//    {
//        private readonly ApplicationDbContext db;
//        public ProductController(ApplicationDbContext context)
//        {
//            db = context;
//        }
//        public IActionResult Index()
//        {
//            //ProductViewModel productViewModel = new ProductViewModel();
//            //db.products = productViewModel.allProducts();
//            var products = db.Product.ToList();
//            return View(products);
//        }

        //public List<Product> _products { get; set; }//Declared list.
        //public int Id { get; private set; }

        //public List<Product> allProducts()//Method to see list.  
        //{
        //    _products = new List<Product>();
        //    return _products;
        //}

        //public Product find(string id)//Method to search by Id.
        //{
        //    List<Product> products = allProducts();
        //    var foundProduct = products.Where(a => a.ProductId == Id).FirstOrDefault();//Check "Id" if problem.
        //    return foundProduct;
        //}



//    }

//}
