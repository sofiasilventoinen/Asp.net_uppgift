using System.ComponentModel.DataAnnotations;

namespace ASP.Net_Inlamningsuppgift.Models.Entities
{
    public class ProductsEntity
    {
        
        [Key]
        public string SKU { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; } 
        public int DiscountPrice { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string LongDescription { get; set; } = string.Empty;

    }
}
