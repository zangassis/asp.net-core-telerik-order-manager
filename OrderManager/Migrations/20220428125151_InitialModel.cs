using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderManager.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Freight = table.Column<decimal>(type: "TEXT", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ShipCity = table.Column<string>(type: "TEXT", nullable: true),
                    ShipName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 1, 10m, new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample1", "ShipNameExample1" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 2, 20m, new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample2", "ShipNameExample2" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 3, 30m, new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample3", "ShipNameExample3" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 4, 40m, new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample4", "ShipNameExample4" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 5, 50m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample5", "ShipNameExample5" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 6, 60m, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample6", "ShipNameExample6" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 7, 70m, new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample7", "ShipNameExample7" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 8, 80m, new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample8", "ShipNameExample8" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 9, 90m, new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample9", "ShipNameExample9" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 10, 100m, new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample10", "ShipNameExample10" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 11, 110m, new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample11", "ShipNameExample11" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 12, 120m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample12", "ShipNameExample12" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 13, 130m, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample13", "ShipNameExample13" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 14, 140m, new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample14", "ShipNameExample14" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 15, 150m, new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample15", "ShipNameExample15" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 16, 160m, new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample16", "ShipNameExample16" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 17, 170m, new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample17", "ShipNameExample17" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 18, 180m, new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample18", "ShipNameExample18" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 19, 190m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample19", "ShipNameExample19" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 20, 200m, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample20", "ShipNameExample20" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 21, 210m, new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample21", "ShipNameExample21" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 22, 220m, new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample22", "ShipNameExample22" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 23, 230m, new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample23", "ShipNameExample23" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 24, 240m, new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample24", "ShipNameExample24" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 25, 250m, new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample25", "ShipNameExample25" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 26, 260m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample26", "ShipNameExample26" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 27, 270m, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample27", "ShipNameExample27" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 28, 280m, new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample28", "ShipNameExample28" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 29, 290m, new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample29", "ShipNameExample29" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Freight", "OrderDate", "ShipCity", "ShipName" },
                values: new object[] { 30, 300m, new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipCityExample30", "ShipNameExample30" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
