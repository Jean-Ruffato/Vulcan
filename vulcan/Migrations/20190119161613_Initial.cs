using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vulcan.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vulnerabilities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Product = table.Column<string>(nullable: true),
                    Version = table.Column<double>(nullable: false),
                    VulnerabilitieID = table.Column<string>(nullable: true),
                    VulnerabilitieName = table.Column<string>(nullable: true),
                    ConfidentialityImpact = table.Column<string>(nullable: true),
                    IntegrityImpact = table.Column<string>(nullable: true),
                    AvaliabilityImpact = table.Column<string>(nullable: true),
                    AccessComplexity = table.Column<string>(nullable: true),
                    Authentication = table.Column<string>(nullable: true),
                    GainedAccess = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    Gravity = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vulnerabilities", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vulnerabilities");
        }
    }
}
