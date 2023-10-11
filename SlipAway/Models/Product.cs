using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlipAway.Models
{
    //Creating the product model with the required 6 attribute
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public double CustomerReview { get; set; }
    }
}
