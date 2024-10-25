
using Microsoft.EntityFrameworkCore;

namespace Web.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Address data
            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = 1, // Ensure this ID matches with Onwer's AddressId
                    Street = "123 Main St",
                    City = "Sample City",
                    Number = 100
                }
            );

            // Seed Onwer data
            modelBuilder.Entity<Owner>().HasData(
                new Owner
                {
                    Id = 1,
                    FullName = "Yehia Nour",
                    Profile = "Software Engineer || Backend Developer (Asp.Net Core Api, MVC, EF)",
                    Image = "Me.jpg",
                    AddressId = 1 // This must match the Address.Id
                }
            );
        }
        public DbSet<Owner> owner { get; set; }
        public DbSet<PortfolioItem> portfolioItems { get; set; }

    }
}
