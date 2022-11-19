namespace DataAccessLayer.Migrations
{
    using BusinessLayer;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Jackets.Add(new Jacket()
            {
                Name = "Sample text",
                Brand = "Sample text",
                Price = 0.0,
                Color = "Sample text",
                Size = JacketAndTrousersSize.SampleSize
            });

            context.Shirts.Add(new Shirt()
            {
                Name = "Sample text",
                Brand = "Sample text",
                Price = 0.0,
                Color = "Sample text",
                Size = ShirtSize.XL
            });

            context.Trousers.Add(new Trousers()
            {
                Name = "Sample text",
                Brand = "Sample text",
                Price = 0.0,
                Color = "Sample text",
                Size = JacketAndTrousersSize.SampleSize
            });

            context.Shoes.Add(new Shoes()
            {
                Name = "Sample text",
                Brand = "Sample text",
                Price = 0.0,
                Color = "Sample text",
                Size = ShoeSize.SampleSize
            });

            context.SaveChanges();
        }
    }
}
