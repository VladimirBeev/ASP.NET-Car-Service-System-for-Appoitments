using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarService.Migrations
{
    public partial class AddEntitiesValidation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfPay",
                table: "Payments",
                newName: "Date Of Pay");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Employees",
                newName: "Start Date");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Employees",
                newName: "Last Name");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Employees",
                newName: "End Date");

            migrationBuilder.RenameColumn(
                name: "Vin",
                table: "Cars",
                newName: "Vin Number");

            migrationBuilder.RenameColumn(
                name: "TransmissionType",
                table: "Cars",
                newName: "Transmission Type");

            migrationBuilder.RenameColumn(
                name: "RegNum",
                table: "Cars",
                newName: "Registration Number");

            migrationBuilder.RenameColumn(
                name: "FuelType",
                table: "Cars",
                newName: "Fuel Type");

            migrationBuilder.RenameColumn(
                name: "EngineType",
                table: "Cars",
                newName: "Engine Type");

            migrationBuilder.RenameColumn(
                name: "EnginePower",
                table: "Cars",
                newName: "Engine Power");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "CarOwners",
                newName: "Phone Number");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "CarOwners",
                newName: "Date Of Birth");

            migrationBuilder.RenameColumn(
                name: "AppointmentDateTime",
                table: "Appointments",
                newName: "Appointment Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date Of Pay",
                table: "Payments",
                newName: "DateOfPay");

            migrationBuilder.RenameColumn(
                name: "Start Date",
                table: "Employees",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Last Name",
                table: "Employees",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "End Date",
                table: "Employees",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "Vin Number",
                table: "Cars",
                newName: "Vin");

            migrationBuilder.RenameColumn(
                name: "Transmission Type",
                table: "Cars",
                newName: "TransmissionType");

            migrationBuilder.RenameColumn(
                name: "Registration Number",
                table: "Cars",
                newName: "RegNum");

            migrationBuilder.RenameColumn(
                name: "Fuel Type",
                table: "Cars",
                newName: "FuelType");

            migrationBuilder.RenameColumn(
                name: "Engine Type",
                table: "Cars",
                newName: "EngineType");

            migrationBuilder.RenameColumn(
                name: "Engine Power",
                table: "Cars",
                newName: "EnginePower");

            migrationBuilder.RenameColumn(
                name: "Phone Number",
                table: "CarOwners",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Date Of Birth",
                table: "CarOwners",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "Appointment Date",
                table: "Appointments",
                newName: "AppointmentDateTime");
        }
    }
}
