namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RootDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jackets",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Size = c.Int(nullable: false),
                        Brand = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Color = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.Shirts",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Size = c.Int(nullable: false),
                        Brand = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Color = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.Shoes",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Size = c.Int(nullable: false),
                        Brand = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Color = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.Trousers",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Size = c.Int(nullable: false),
                        Brand = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Color = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trousers");
            DropTable("dbo.Shoes");
            DropTable("dbo.Shirts");
            DropTable("dbo.Jackets");
        }
    }
}
