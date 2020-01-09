using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mijalski.EntityFrameworkCore.Migrations
{
    public partial class seeddata3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("a4fa85c5-017c-4d28-b6cd-396da935cc58"), new DateTime(2020, 1, 9, 20, 54, 50, 690, DateTimeKind.Utc).AddTicks(9271), "Nvidia" });

            migrationBuilder.InsertData(
                table: "AppGraphicCards",
                columns: new[] { "Id", "CreationDateTime", "InterfaceType", "Name", "Price", "ProcessorSpeed", "VendorId", "Wattage" },
                values: new object[] { new Guid("e162c5fb-de2d-4a12-9048-0d5173b5b988"), new DateTime(2020, 1, 9, 20, 54, 50, 691, DateTimeKind.Utc).AddTicks(4295), "PCI Express 3.0", "GTX 970", 330m, "1753MHz", new Guid("a4fa85c5-017c-4d28-b6cd-396da935cc58"), 145.0 });

            migrationBuilder.InsertData(
                table: "AppGraphicCards",
                columns: new[] { "Id", "CreationDateTime", "InterfaceType", "Name", "Price", "ProcessorSpeed", "VendorId", "Wattage" },
                values: new object[] { new Guid("a0a785d4-9aee-4184-bca2-2b826b08a0b3"), new DateTime(2020, 1, 9, 20, 54, 50, 695, DateTimeKind.Utc).AddTicks(9565), "PCI Express 3.0", "RTX 2070 Super", 609m, "1605Mhz + Boost", new Guid("a4fa85c5-017c-4d28-b6cd-396da935cc58"), 160.0 });

            migrationBuilder.InsertData(
                table: "AppRams",
                columns: new[] { "GraphicCardId", "Capacity", "TypeOfRam" },
                values: new object[] { new Guid("e162c5fb-de2d-4a12-9048-0d5173b5b988"), 4, "GDDR5" });

            migrationBuilder.InsertData(
                table: "AppRams",
                columns: new[] { "GraphicCardId", "Capacity", "TypeOfRam" },
                values: new object[] { new Guid("a0a785d4-9aee-4184-bca2-2b826b08a0b3"), 8, "GDDR5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRams",
                keyColumn: "GraphicCardId",
                keyValue: new Guid("a0a785d4-9aee-4184-bca2-2b826b08a0b3"));

            migrationBuilder.DeleteData(
                table: "AppRams",
                keyColumn: "GraphicCardId",
                keyValue: new Guid("e162c5fb-de2d-4a12-9048-0d5173b5b988"));

            migrationBuilder.DeleteData(
                table: "AppGraphicCards",
                keyColumn: "Id",
                keyValue: new Guid("a0a785d4-9aee-4184-bca2-2b826b08a0b3"));

            migrationBuilder.DeleteData(
                table: "AppGraphicCards",
                keyColumn: "Id",
                keyValue: new Guid("e162c5fb-de2d-4a12-9048-0d5173b5b988"));

            migrationBuilder.DeleteData(
                table: "AppVendors",
                keyColumn: "Id",
                keyValue: new Guid("a4fa85c5-017c-4d28-b6cd-396da935cc58"));

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
    }
}
