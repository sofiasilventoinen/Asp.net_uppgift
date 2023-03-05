using ASP.Net_Inlamningsuppgift.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Inlamningsuppgift.Contexts
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions <DataContext> options) : base(options)
        {
        }

        public DbSet <ProductsEntity> Products { get; set; }
        public DbSet<ShowcaseEntity> Showcase { get; set; }

    }
}
