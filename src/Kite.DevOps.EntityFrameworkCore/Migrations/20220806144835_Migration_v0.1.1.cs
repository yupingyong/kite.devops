using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kite.DevOps.EntityFrameworkCore.Migrations
{
    public partial class Migration_v011 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "ServerInfos",
                type: "TEXT",
                maxLength: 512,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "ServerInfos");
        }
    }
}
