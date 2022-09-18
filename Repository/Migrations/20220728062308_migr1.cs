using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net6Repository.Migrations
{
    public partial class migr1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "repositorys",
                columns: table => new
                {
                    SathyaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SathyaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SathyaLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repositorys", x => x.SathyaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "repositorys");
        }
    }
}
