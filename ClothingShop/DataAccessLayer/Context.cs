using BusinessLayer;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        public Context() : base("PHAssignment")
        { }

        public DbSet<Shirt> Shirts { get; set; }
        public DbSet<Shoes> Shoes { get; set; }
        public DbSet<Jacket> Jackets { get; set; }
        public DbSet<Trousers> Trousers { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}