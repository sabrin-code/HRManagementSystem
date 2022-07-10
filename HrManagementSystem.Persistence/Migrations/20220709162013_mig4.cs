using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HrManagementSystem.Persistence.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_AspNetUsers_UserId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_UserId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "AspNetRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "CreateUserId",
                table: "AspNetRoles",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UpdateUserId",
                table: "AspNetRoles",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserId",
                table: "Employee",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_AspNetUsers_UserId",
                table: "Employee",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
