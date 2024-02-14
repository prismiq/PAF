using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAFApi.Migrations
{
    /// <inheritdoc />
    public partial class RemoveId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Address");

            migrationBuilder.AlterColumn<int>(
                name: "AddressKey",
                table: "Address",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddressKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.AlterColumn<int>(
                name: "AddressKey",
                table: "Address",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Address",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "AddressKey", "BuildingName", "BuildingNumber", "DeliveryPointSuffix", "DepartmentName", "DependentLocality", "DependentThoroughfareDescriptor", "DoubleDependentLocality", "LocalityKey", "NumberOfHouseholds", "OrganisationKey", "OrganisationName", "POBox", "PostCode", "PostTown", "PostcodeType", "SUOrganisationIndicator", "SubBuildingName", "ThoroughfareDescriptor", "UDPRN" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });
        }
    }
}
