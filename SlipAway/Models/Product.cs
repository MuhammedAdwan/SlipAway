using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SlipAway.Models
{
    //Creating the product model with the required 6 attribute
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Please enter the product name.")]
        [StringLength(7, ErrorMessage = "The name cannot be more than 7 characters long.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        [StringLength(20, ErrorMessage = "The description cannot be more than 20 characters long.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter a price.")]
        [Range(0.01, 1000, ErrorMessage = "Price must be between 0.01 and 1000.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter a category.")]

        public string Category { get; set; }

        [StringLength(20, ErrorMessage = "The name cannot be more than 20 characters long.")]
        public string ImageUrl { get; set; }
        [Range(0, 5, ErrorMessage = "Review must be between 0 and 5.")]

        public double CustomerReview { get; set; }
    }
}
