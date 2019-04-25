

namespace productoback.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name="Product Name")]
        public string Name { get; set; }

        public int Price { get; set; }
    }
}