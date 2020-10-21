using GrantParkCoffeeShop2.Data;
using GrantParkCoffeeShop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.ViewsOfShop
{
    public class ProductViewModel
    {
        public List<Product> Product { get; set; }//Declared list.
        public int Id { get; private set; }

        public List<Product> FindAllProducts()//Method to see list.  
        {
            var products = Product.ToList();
            return View(products);
        }

        private List<Product> View(List<Product> products)
        {
            throw new NotImplementedException();
        }

        public Product Find(string id)//Method to search by Id.
        {
            List<Product> products = FindAllProducts();
            var foundProduct = products.Where(a => a.ProductId == Id).FirstOrDefault();//Check "Id" if problem.
            return foundProduct;
        }





















    }
}
