using System;
using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please Enter a Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter a Author Name")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please Enter a Product Price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please Enter a Product Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please Enter a Product Genre")]
        public string GenreID { get; set; }
        public Genre Genre { get; set; }

        public DateTime Published { get; set; }
        public string LastUpdatedBy { get; set; } = "adminAccount";
        public DateTime LastUpdated { get; set; } = DateTime.Now;
    }
}
