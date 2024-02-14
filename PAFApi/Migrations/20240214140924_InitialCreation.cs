using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAFApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PostTown = table.Column<string>(type: "TEXT", nullable: true),
                    DependentLocality = table.Column<string>(type: "TEXT", nullable: true),
                    DoubleDependentLocality = table.Column<string>(type: "TEXT", nullable: true),
                    ThoroughfareDescriptor = table.Column<string>(type: "TEXT", nullable: true),
                    DependentThoroughfareDescriptor = table.Column<string>(type: "TEXT", nullable: true),
                    BuildingNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    BuildingName = table.Column<string>(type: "TEXT", nullable: true),
                    SubBuildingName = table.Column<string>(type: "TEXT", nullable: true),
                    POBox = table.Column<string>(type: "TEXT", nullable: true),
                    DepartmentName = table.Column<string>(type: "TEXT", nullable: true),
                    OrganisationName = table.Column<string>(type: "TEXT", nullable: true),
                    UDPRN = table.Column<int>(type: "INTEGER", nullable: true),
                    PostcodeType = table.Column<string>(type: "TEXT", nullable: true),
                    SUOrganisationIndicator = table.Column<string>(type: "TEXT", nullable: true),
                    DeliveryPointSuffix = table.Column<string>(type: "TEXT", nullable: true),
                    AddressKey = table.Column<int>(type: "INTEGER", nullable: true),
                    OrganisationKey = table.Column<int>(type: "INTEGER", nullable: true),
                    NumberOfHouseholds = table.Column<int>(type: "INTEGER", nullable: true),
                    LocalityKey = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "AddressKey", "BuildingName", "BuildingNumber", "DeliveryPointSuffix", "DepartmentName", "DependentLocality", "DependentThoroughfareDescriptor", "DoubleDependentLocality", "LocalityKey", "NumberOfHouseholds", "OrganisationKey", "OrganisationName", "POBox", "PostTown", "PostcodeType", "SUOrganisationIndicator", "SubBuildingName", "ThoroughfareDescriptor", "UDPRN" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
