using Microsoft.EntityFrameworkCore.Migrations;

namespace UHype.Migrations
{
    public partial class ChartsCont : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "BpControl",
                table: "Charts",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<bool>(
                name: "FollowUp",
                table: "Charts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BpControl",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "FollowUp",
                table: "Charts");
        }
    }
}
