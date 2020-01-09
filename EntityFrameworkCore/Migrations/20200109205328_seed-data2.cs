using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mijalski.EntityFrameworkCore.Migrations
{
    public partial class seeddata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppGraphicCards",
                keyColumn: "Id",
                keyValue: new Guid("c12a6777-70fc-476b-b59b-58ad754fb7ec"));

            migrationBuilder.DeleteData(
                table: "AppGraphicCards",
                keyColumn: "Id",
                keyValue: new Guid("cf92d8b9-4bc9-4c2e-8a9c-ac8df80c7c9e"));

            migrationBuilder.DeleteData(
                table: "AppVendors",
                keyColumn: "Id",
                keyValue: new Guid("5266b65c-706e-46a5-a44c-74848cf085f0"));

            migrationBuilder.InsertData(
                table: "AppVendors",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[] { new Guid("3abfbdc1-4f55-4251-b91f-e47f811f6658"), new DateTime(2020, 1, 9, 20, 53, 27, 185, DateTimeKind.Utc).AddTicks(4266), "Nvidia" });

            migrationBuilder.InsertData(
                table: "AppGraphicCards",
                columns: new[] { "Id", "CreationDateTime", "InterfaceType", "Name", "Price", "ProcessorSpeed", "VendorId", "Wattage" },
                values: new object[] { new Guid("bb58d505-e983-43a0-bded-44f9ec8e45ef"), new DateTime(2020, 1, 9, 20, 53, 27, 185, DateTimeKind.Utc).AddTicks(9890), "PCI Express 3.0", "GTX 970", 330m, "1753MHz", new Guid("3abfbdc1-4f55-4251-b91f-e47f811f6658"), 145.0 });

            migrationBuilder.InsertData(
                table: "AppGraphicCards",
                columns: new[] { "Id", "CreationDateTime", "InterfaceType", "Name", "Price", "ProcessorSpeed", "VendorId", "Wattage" },
                values: new object[] { new Guid("863e110e-756e-4f4f-a71c-9242e1e4695f"), new DateTime(2020, 1, 9, 20, 53, 27, 186, DateTimeKind.Utc).AddTicks(5247), "PCI Express 3.0", "RTX 2070 Super", 609m, "1605Mhz + Boost", new Guid("3abfbdc1-4f55-4251-b91f-e47f811f6658"), 160.0 });

            migrationBuilder.InsertData(
                table: "AppRams",
                columns: new[] { "GraphicCardId", "Capacity", "TypeOfRam" },
                values: new object[] { new Guid("bb58d505-e983-43a0-bded-44f9ec8e45ef"), 8, "GDDR6" });

            migrationBuilder.InsertData(
                table: "AppRams",
                columns: new[] { "GraphicCardId", "Capacity", "TypeOfRam" },
                values: new object[] { new Guid("863e110e-756e-4f4f-a71c-9242e1e4695f"), 8, "GDDR5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRams",
                keyColumn: "GraphicCardId",
                keyValue: new Guid("863e110e-756e-4f4f-a71c-9242e1e4695f"));

            migrationBuilder.DeleteData(
                table: "AppRams",
                keyColumn: "GraphicCardId",
                keyValue: new Guid("bb58d505-e983-43a0-bded-44f9ec8e45ef"));

            migrationBuilder.DeleteData(
                table: "AppGraphicCards",
                keyColumn: "Id",
                keyValue: new Guid("863e110e-756e-4f4f-a71c-9242e1e4695f"));

            migrationBuilder.DeleteData(
                table: "AppGraphicCards",
                keyColumn: "Id",
                keyValue: new Guid("bb58d505-e983-43a0-bded-44f9ec8e45ef"));

            migrationBuilder.DeleteData(
                table: "AppVendors",
                keyColumn: "Id",
                keyValue: new Guid("3abfbdc1-4f55-4251-b91f-e47f811f6658"));

            migrationBuilder.InsertData(
                table: "AppVendors",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[] { new Guid("5266b65c-706e-46a5-a44c-74848cf085f0"), new DateTime(2020, 1, 9, 20, 51, 58, 166, DateTimeKind.Utc).AddTicks(3409), "Nvidia" });

            migrationBuilder.InsertData(
                table: "AppGraphicCards",
                columns: new[] { "Id", "CreationDateTime", "InterfaceType", "Name", "Price", "ProcessorSpeed", "VendorId", "Wattage" },
                values: new object[] { new Guid("c12a6777-70fc-476b-b59b-58ad754fb7ec"), new DateTime(2020, 1, 9, 20, 51, 58, 166, DateTimeKind.Utc).AddTicks(8127), "PCI Express 3.0", "GTX 970", 330m, "1753MHz", new Guid("5266b65c-706e-46a5-a44c-74848cf085f0"), 145.0 });

            migrationBuilder.InsertData(
                table: "AppGraphicCards",
                columns: new[] { "Id", "CreationDateTime", "InterfaceType", "Name", "Price", "ProcessorSpeed", "VendorId", "Wattage" },
                values: new object[] { new Guid("cf92d8b9-4bc9-4c2e-8a9c-ac8df80c7c9e"), new DateTime(2020, 1, 9, 20, 51, 58, 167, DateTimeKind.Utc).AddTicks(3226), "PCI Express 3.0", "RTX 2070 Super", 609m, "1605Mhz + Boost", new Guid("5266b65c-706e-46a5-a44c-74848cf085f0"), 160.0 });
        }
    }
}
