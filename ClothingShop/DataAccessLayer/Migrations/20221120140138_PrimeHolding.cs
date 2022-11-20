using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class PrimeHolding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clothes",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothes", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Name", "Brand", "Color", "Price", "Size", "Type" },
                values: new object[,]
                {
                    { "Black Linen Trousers", "LC Waikiki", "Black", 40.0, "34", 2 },
                    { "Jean Shirt", "Wyoming", "Light Blue", 15.0, "L", 1 },
                    { "Red linen jacket", "LC Waikiki", "Red", 50.0, "46", 0 },
                    { "Sports Shoes", "Decathlon", "Light Brown", 35.0, "44", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clothes");
        }
    }
}
