using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Framework1.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordColumnInEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                schema: "dbo",
                table: "Hamada",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                schema: "dbo",
                table: "Hamada");
        }
    }
}
