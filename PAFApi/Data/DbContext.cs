using Microsoft.EntityFrameworkCore;
using PAFApi.Models;

namespace Db
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options)
        {
        }

        // DbSet properties for your entities
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
            .Property(a => a.Id)
            .ValueGeneratedOnAdd(); // Configures Id as an identity column
        }
    }
}
