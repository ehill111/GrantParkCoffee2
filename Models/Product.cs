using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "Product Type")]
        public string ProductType { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Product Price")]
        public double UnitPrice { get; set; }
        [Display(Name = "Product Featured")]
        public bool ProductFeatured { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Product On Sale")]
        public bool ProductOnSale { get; set; }
        [Display(Name = "Reward Eligible")]
        public bool RewardEligible { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
    
}
