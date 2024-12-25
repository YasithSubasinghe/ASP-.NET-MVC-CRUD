using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceStation.Web.Migrations
{
    /// <inheritdoc />
    public partial class TansactionModelChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "VehicleServiceId",
                table: "Transactions");

            migrationBuilder.AddColumn<string>(
                name: "CustomerFullName",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeFullName",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VehicleServiceTitle",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerFullName",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "EmployeeFullName",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "VehicleServiceTitle",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "Transactions");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VehicleServiceId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
