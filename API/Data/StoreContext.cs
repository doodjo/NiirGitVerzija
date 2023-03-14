using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options) {

        }

// Svaki proizvod ce biti jedna kolona i to predstavlja ovaj DbSet
        public DbSet<Product> Products { get; set; }
    }
}