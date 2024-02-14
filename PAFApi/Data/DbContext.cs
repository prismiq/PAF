using Microsoft.EntityFrameworkCore;
using PAFApi.Models;

namespace Db
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        // DbSet properties for your entities
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity mappings here (optional)
            // Example:
            // modelBuilder.Entity<User>().ToTable("Users");
            // modelBuilder.Entity<Address>().ToTable("Addresses");
        }
    }
}
