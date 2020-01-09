using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mijalski.EntityFrameworkCore.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppGraphicCards_AppVendors_VendorId1",
                table: "AppGraphicCards");

            migrationBuilder.DropIndex(
                name: "IX_AppGraphicCards_VendorId1",
                table: "AppGraphicCards");

            migrationBuilder.DropColumn(
                name: "RamSize",
                table: "AppRams");

            migrationBuilder.DropColumn(
                name: "VendorId1",
                table: "AppGraphicCards");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "AppRams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Wattage",
                table: "AppGraphicCards",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "AppGraphicCards",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "AppRams");

            migrationBuilder.AddColumn<int>(
                name: "RamSize",
                table: "AppRams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Wattage",
                table: "AppGraphicCards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "AppGraphicCards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<Guid>(
                name: "VendorId1",
                table: "AppGraphicCards",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppGraphicCards_VendorId1",
                table: "AppGraphicCards",
                column: "VendorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AppGraphicCards_AppVendors_VendorId1",
                table: "AppGraphicCards",
                column: "VendorId1",
                principalTable: "AppVendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
