using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "PRF", "Perfumería" },
                    { "SLD", "Salud" },
                    { "VDJ", "Videojuegos" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "362dbe32-b67f-4585-8bb4-0d0bfb49b356", "Calle 1", "Bodega Central" },
                    { "e6123205-932f-4c26-bcd8-4a124edbf3b0", "Calle 2", "Bodega Norte" },
                    { "d515f990-db16-4c97-9da7-0d6b647099d6", "Calle 3", "Bodega Sur" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "PRF");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "SLD");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "VDJ");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "362dbe32-b67f-4585-8bb4-0d0bfb49b356");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "d515f990-db16-4c97-9da7-0d6b647099d6");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "e6123205-932f-4c26-bcd8-4a124edbf3b0");
        }
    }
}
