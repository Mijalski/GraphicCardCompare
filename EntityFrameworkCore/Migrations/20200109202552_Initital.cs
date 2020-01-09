using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mijalski.EntityFrameworkCore.Migrations
{
    public partial class Initital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppVendors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDateTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppVendors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppGraphicCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDateTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    InterfaceType = table.Column<string>(nullable: true),
                    ProcessorSpeed = table.Column<string>(nullable: true),
                    Wattage = table.Column<string>(nullable: true),
                    VendorId = table.Column<Guid>(nullable: false),
                    VendorId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppGraphicCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppGraphicCards_AppVendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "AppVendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppGraphicCards_AppVendors_VendorId1",
                        column: x => x.VendorId1,
                        principalTable: "AppVendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppRams",
                columns: table => new
                {
                    GraphicCardId = table.Column<Guid>(nullable: false),
                    RamSize = table.Column<int>(nullable: false),
                    TypeOfRam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRams", x => x.GraphicCardId);
                    table.ForeignKey(
                        name: "FK_AppRams_AppGraphicCards_GraphicCardId",
                        column: x => x.GraphicCardId,
                        principalTable: "AppGraphicCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppGraphicCards_Name",
                table: "AppGraphicCards",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_AppGraphicCards_VendorId",
                table: "AppGraphicCards",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_AppGraphicCards_VendorId1",
                table: "AppGraphicCards",
                column: "VendorId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppVendors_Name",
                table: "AppVendors",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRams");

            migrationBuilder.DropTable(
                name: "AppGraphicCards");

            migrationBuilder.DropTable(
                name: "AppVendors");
        }
    }
}
