using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseTransactions.Migrations
{
    public partial class RequiredValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Town",
                table: "Peoples",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Peoples",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Peoples",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Peoples",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 25, 22, 49, 11, 74, DateTimeKind.Local).AddTicks(3521),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2021, 5, 25, 21, 37, 21, 917, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Peoples",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Town",
                table: "Peoples",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Peoples",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Peoples",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Peoples",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 25, 21, 37, 21, 917, DateTimeKind.Local).AddTicks(1855),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2021, 5, 25, 22, 49, 11, 74, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Peoples",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
