using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInfoDemo.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "stuadhaar",
                table: "Students",
                type: "varchar(12)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "stuadhaar",
                table: "Students");
        }
    }
}
