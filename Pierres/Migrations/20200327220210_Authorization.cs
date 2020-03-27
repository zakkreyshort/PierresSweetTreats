using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pierres.Migrations
{
    public partial class Authorization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Treats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TreatFlavor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FlavorName",
                table: "Flavors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatronId",
                table: "Flavors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TreatFlavorId",
                table: "Flavors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Patrons",
                columns: table => new
                {
                    PatronId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PatronName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patrons", x => x.PatronId);
                    table.ForeignKey(
                        name: "FK_Patrons_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Checkout",
                columns: table => new
                {
                    CheckoutId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FlavorId = table.Column<int>(nullable: false),
                    PatronId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkout", x => x.CheckoutId);
                    table.ForeignKey(
                        name: "FK_Checkout_Flavors_FlavorId",
                        column: x => x.FlavorId,
                        principalTable: "Flavors",
                        principalColumn: "FlavorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkout_Patrons_PatronId",
                        column: x => x.PatronId,
                        principalTable: "Patrons",
                        principalColumn: "PatronId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkout_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Treats_UserId",
                table: "Treats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatFlavor_UserId",
                table: "TreatFlavor",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_FlavorId",
                table: "Checkout",
                column: "FlavorId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_PatronId",
                table: "Checkout",
                column: "PatronId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_UserId",
                table: "Checkout",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_UserId",
                table: "Patrons",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavor_AspNetUsers_UserId",
                table: "TreatFlavor",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavor_AspNetUsers_UserId",
                table: "TreatFlavor");

            migrationBuilder.DropForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats");

            migrationBuilder.DropTable(
                name: "Checkout");

            migrationBuilder.DropTable(
                name: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Treats_UserId",
                table: "Treats");

            migrationBuilder.DropIndex(
                name: "IX_TreatFlavor_UserId",
                table: "TreatFlavor");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Treats");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TreatFlavor");

            migrationBuilder.DropColumn(
                name: "FlavorName",
                table: "Flavors");

            migrationBuilder.DropColumn(
                name: "PatronId",
                table: "Flavors");

            migrationBuilder.DropColumn(
                name: "TreatFlavorId",
                table: "Flavors");
        }
    }
}
