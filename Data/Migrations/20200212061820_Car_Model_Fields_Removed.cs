using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Car_Model_Fields_Removed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EngineCapacity",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasABS",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasAirConditioning",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasAlarm",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasClimateControl",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasElectricMirrors",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasHesatedSeats",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasLeatherInterior",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasNavigation",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasParkingControl",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasRearCamera",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HasTCS",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "InteriorColor",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "IsValidated",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "NumberOfAirbags",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "NumberOfCylinders",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "NumberOfDoors",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Odometer",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SaleType",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SellerName",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SellerNumber",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SteeringWheelPosition",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Transmission",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "WheelDriveType",
                table: "Cars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Cars",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EngineCapacity",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FuelType",
                table: "Cars",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasABS",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasAirConditioning",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasAlarm",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasClimateControl",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasElectricMirrors",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasHesatedSeats",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasLeatherInterior",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasNavigation",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasParkingControl",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasRearCamera",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasTCS",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "InteriorColor",
                table: "Cars",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsValidated",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfAirbags",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfCylinders",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfDoors",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Odometer",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SaleType",
                table: "Cars",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SellerName",
                table: "Cars",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SellerNumber",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SteeringWheelPosition",
                table: "Cars",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Transmission",
                table: "Cars",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WheelDriveType",
                table: "Cars",
                nullable: false,
                defaultValue: "");
        }
    }
}
