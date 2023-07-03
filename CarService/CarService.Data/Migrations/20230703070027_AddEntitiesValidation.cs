using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarService.Migrations
{
    public partial class AddEntitiesValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TransmissionType",
                table: "Cars",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                comment: "Type of Transmission",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true,
                oldComment: "Type of Transmission");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Cars",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Car Model",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldComment: "Car Model");

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "Cars",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Car Make",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldComment: "Car Make");

            migrationBuilder.AlterColumn<int>(
                name: "Kilometers",
                table: "Cars",
                type: "int",
                maxLength: 7,
                nullable: true,
                comment: "Kilometers",
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true,
                oldComment: "Kilometers");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Cars",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                comment: "Color of car",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true,
                oldComment: "Color of car");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "CarOwners",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Password of owner",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Password of owner");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CarOwners",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                comment: "Name of owner",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Name of owner");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "CarOwners",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Email of owner",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldComment: "Email of owner");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TransmissionType",
                table: "Cars",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                comment: "Type of Transmission",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldComment: "Type of Transmission");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Cars",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                comment: "Car Model",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Car Model");

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "Cars",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                comment: "Car Make",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Car Make");

            migrationBuilder.AlterColumn<string>(
                name: "Kilometers",
                table: "Cars",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                comment: "Kilometers",
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 7,
                oldNullable: true,
                oldComment: "Kilometers");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Cars",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                comment: "Color of car",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldComment: "Color of car");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "CarOwners",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Password of owner",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Password of owner");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CarOwners",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Name of owner",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldComment: "Name of owner");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "CarOwners",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                comment: "Email of owner",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Email of owner");
        }
    }
}
