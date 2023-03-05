﻿namespace ASP.Net_Inlamningsuppgift.Models.Products
{
    public class ProductsCardModel
    {
        public string SKU { get; set; } = string.Empty;
        public string ImgUrl { get; set; } = string.Empty;
        public string ImgAlt { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public bool New { get; set; } = false;
        public int TotalComments { get; set; }
        public int? Rating { get; set; }
        
        public string? ShortDescription { get; set; } = "";
        public string? LongDescription { get; set; } = "";
        public string Category { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}

