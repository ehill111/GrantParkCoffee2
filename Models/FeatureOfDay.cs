using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Models
{
    public class FeatureOfDay
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Featured Menu Item")]
        public string FeaturedProduct { get; set; }

    }
}
