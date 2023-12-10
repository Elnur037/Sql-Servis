using Microsoft.EntityFrameworkCore;
using Sql_Servis.Models;

namespace Sql_Servis.DAL
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> option):base(option)
        {
            
        }
        public DbSet<Service> Services { get; set; }
    }
}
