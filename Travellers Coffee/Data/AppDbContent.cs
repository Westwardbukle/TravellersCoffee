using Microsoft.EntityFrameworkCore;
using Travellers_Coffee.Data.Models;

namespace Travellers_Coffee.Data
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {
            
        }
        
        public DbSet<Coffe> Coffe { get; set; }
        
        public DbSet<Category> Category { get; set; }
        
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        
        
    }
}