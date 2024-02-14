using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAFApi.Migrations
{
    /// <inheritdoc />
    public partial class AddPostcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "Address",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostCode",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "Address");
        }
    }
}
