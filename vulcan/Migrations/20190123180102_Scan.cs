using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vulcan.Migrations
{
    public partial class Scan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScanID",
                table: "Vulnerabilities",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Scan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ScanID = table.Column<int>(nullable: false),
                    Host = table.Column<string>(nullable: true),
                    OperatingSystem = table.Column<string>(nullable: true),
                    SoftwareName = table.Column<string>(nullable: true),
                    SoftwareVersion = table.Column<string>(nullable: true),
                    VulnerabilitiesQuantity = table.Column<int>(nullable: false),
                    ScanStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scan", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vulnerabilities_ScanID",
                table: "Vulnerabilities",
                column: "ScanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vulnerabilities_Scan_ScanID",
                table: "Vulnerabilities",
                column: "ScanID",
                principalTable: "Scan",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vulnerabilities_Scan_ScanID",
                table: "Vulnerabilities");

            migrationBuilder.DropTable(
                name: "Scan");

            migrationBuilder.DropIndex(
                name: "IX_Vulnerabilities_ScanID",
                table: "Vulnerabilities");

            migrationBuilder.DropColumn(
                name: "ScanID",
                table: "Vulnerabilities");
        }
    }
}
