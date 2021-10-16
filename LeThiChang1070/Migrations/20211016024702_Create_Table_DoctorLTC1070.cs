using Microsoft.EntityFrameworkCore.Migrations;

namespace LeThiChang1070.Migrations
{
    public partial class Create_Table_DoctorLTC1070 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorLTC1070",
                columns: table => new
                {
                    DortorID = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorLTC1070", x => x.DortorID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorLTC1070");
        }
    }
}
