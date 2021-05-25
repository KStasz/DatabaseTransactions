using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseTransactions.Migrations
{
    public partial class DefaultValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Peoples",
                type: "INTEGER",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Peoples",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 25, 21, 37, 21, 917, DateTimeKind.Local).AddTicks(1855),
                oldClrType: typeof(DateTime),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Peoples",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Peoples",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2021, 5, 25, 21, 37, 21, 917, DateTimeKind.Local).AddTicks(1855));
        }
    }
}
