using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInfoDemo.Migrations
{
    /// <inheritdoc />
    public partial class Second2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "stuphone",
                table: "Students",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "stuname",
                table: "Students",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "stugen",
                table: "Students",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "stuemail",
                table: "Students",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "stuphone",
                table: "Students",
                type: "varchar(100",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "stuname",
                table: "Students",
                type: "varchar(100",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "stugen",
                table: "Students",
                type: "varchar(50",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "stuemail",
                table: "Students",
                type: "varchar(100",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);
        }
    }
}
