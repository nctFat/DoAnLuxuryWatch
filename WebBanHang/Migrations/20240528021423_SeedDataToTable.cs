using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHang.Migrations
{
    public partial class SeedDataToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 1, 1, "Rolex" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 2, 2, "Omega" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 3, 3, "Hublot" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, null, null, "Đồng hồ Rolex Datejust M126233-0017", 300.0 },
                    { 2, 1, null, null, "Đồng Hồ Rolex Datejust 31 278381RBR ", 350.0 },
                    { 3, 1, null, null, "Đồng Hồ Rolex Datejust 31", 400.0 },
                    { 4, 1, null, null, "Rolex M126234-0051", 420.0 },
                    { 5, 2, null, null, "AQUA TERRA 150MCO‑AXIAL MASTER CHRONOMETER 41 MM", 630.0 },
                    { 6, 2, null, null, "Omega Seamaster 220.10.41.21.03.001 Aqua Terra 41mm", 750.0 },
                    { 7, 2, null, null, "Đồng hồ Nam Omega Seamaster 210.90.42.20.01.001 Diver 300M 007 Edition", 820.0 },
                    { 8, 2, null, null, "Đồng hồ Omega Seamaster Aqua Terra Co-Axial Day Date", 950.0 },
                    { 9, 3, null, null, "Hublot 582.NX.1170.RX.1704", 1200.0 },
                    { 10, 3, null, null, "Hublot 542.OX.1181.LR", 1450.0 },
                    { 11, 3, null, null, "Đồng hồ Hublot Spirit of Big Bang King Gold Rainbow 641.OX.0110.LR.0999", 750.0 },
                    { 12, 3, null, null, "Đồng hồ Hublot Classic Fusion Takashi Murakami Sapphire Rainbow 507.JX.0800.RT.TAK21 507JX0800RTTAK21", 1250.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
