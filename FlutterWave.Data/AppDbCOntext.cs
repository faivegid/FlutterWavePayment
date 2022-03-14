using FlutterWave.Models;
using FlutterWave.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FlutterWave.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
