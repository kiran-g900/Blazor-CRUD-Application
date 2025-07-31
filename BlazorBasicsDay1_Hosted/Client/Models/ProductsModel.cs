using System.ComponentModel.DataAnnotations;

namespace BlazorBasicsDay1_Hosted.Client.Models
{
    public class ProductsModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, ErrorMessage = "Name must be under 100 characters.")]
        public string Name { get; set; } = "";

        [Range(1,2000000,ErrorMessage = "Price must be between 1 to 2000000")]
        public decimal Price { get; set; }
    }
}
