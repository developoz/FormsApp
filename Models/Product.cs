using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{   
    public class Product
    {
        [Display(Name="ürün ID")]
        
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }        
    }
}