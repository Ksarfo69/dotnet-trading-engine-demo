using Microsoft.EntityFrameworkCore;
using TradingEngine.Models;

namespace TradingEngine.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Ticker> Tickers { get; set; }

    }
}
