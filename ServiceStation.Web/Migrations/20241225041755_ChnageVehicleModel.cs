using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceStation.Web.Migrations
{
    /// <inheritdoc />
    public partial class ChnageVehicleModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Make",
                table: "Vehicles",
                newName: "Type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Vehicles",
                newName: "Make");
        }
    }
}
