using ASP.Net_Inlamningsuppgift.Contexts;
using ASP.Net_Inlamningsuppgift.Models.Entities;
using ASP.Net_Inlamningsuppgift.Models.Products;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Inlamningsuppgift.Services
{
    public class ProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<ProductsCardModel>> GetAllAsync()
        {
            var products = await _context.Products.ToListAsync();
            
            var productscardmodel = new List<ProductsCardModel>();
            foreach (var product in products) 
            {
                productscardmodel.Add(new ProductsCardModel 
                {
                    SKU = product.SKU,
                    Name= product.Name,
                    Price = product.Price,
                    DiscountPrice= product.DiscountPrice,
                    Category= product.Category,
                    LongDescription= product.LongDescription,
                    ShortDescription = product.Description
                });
            }
            return productscardmodel;
        }
    }
}
