using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        public Context() { }

        public DbSet<Clothing> Clothes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;database=PrimeHolding;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        //Seed with basic data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clothing>().HasData(new Clothing
            {
                Name = "Red linen jacket",
                Brand = "LC Waikiki",
                Price = 50.0,
                Color = "Red",
                Size = "46",
                Type = ClothingType.Jacket
            });

            modelBuilder.Entity<Clothing>().HasData(new Clothing()
            {
                Name = "Jean Shirt",
                Brand = "Wyoming",
                Price = 15.0,
                Color = "Light Blue",
                Size = "L",
                Type = ClothingType.Shirt
            });

            modelBuilder.Entity<Clothing>().HasData(new Clothing()
            {
                Name = "Black Linen Trousers",
                Brand = "LC Waikiki",
                Price = 40.0,
                Color = "Black",
                Size = "34",
                Type = ClothingType.Trousers
            });

            modelBuilder.Entity<Clothing>().HasData(new Clothing()
            {
                Name = "Sports Shoes",
                Brand = "Decathlon",
                Price = 35.0,
                Color = "Light Brown",
                Size = "44",
                Type = ClothingType.Shoes
            });
        }
    }
}