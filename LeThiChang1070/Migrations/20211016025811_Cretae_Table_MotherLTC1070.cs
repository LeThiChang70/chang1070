using Microsoft.EntityFrameworkCore.Migrations;

namespace LeThiChang1070.Migrations
{
    public partial class Cretae_Table_MotherLTC1070 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MotherLTC1070",
                columns: table => new
                {
                    MotherID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotherLTC1070", x => x.MotherID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MotherLTC1070");
        }
    }
}
