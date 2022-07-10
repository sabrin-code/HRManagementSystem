using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrManagementSystem.Persistence.Migrations
{
    public partial class mig557 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "VacationDays");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "VacationDays");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "VacationDays");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "VacationApplication");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "VacationApplication");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "VacationApplication");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Departament");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Departament");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Departament");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CreateUserId",
                table: "VacationDays",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "VacationDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "UpdateUserId",
                table: "VacationDays",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateUserId",
                table: "VacationApplication",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "VacationApplication",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "UpdateUserId",
                table: "VacationApplication",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateUserId",
                table: "Status",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "UpdateUserId",
                table: "Status",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateUserId",
                table: "Position",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Position",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "UpdateUserId",
                table: "Position",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateUserId",
                table: "Employee",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "UpdateUserId",
                table: "Employee",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CreateUserId",
                table: "Departament",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Departament",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "UpdateUserId",
                table: "Departament",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
