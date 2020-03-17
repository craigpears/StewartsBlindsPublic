using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StewartsBlinds.Data.Migrations
{
    public partial class SalesUsersAppointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_SalesUser_SalesUserId",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesUser",
                table: "SalesUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesUsers",
                table: "SalesUser",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_SalesUsers_SalesUserId",
                table: "Appointments",
                column: "SalesUserId",
                principalTable: "SalesUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "SalesUser",
                newName: "SalesUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_SalesUsers_SalesUserId",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesUsers",
                table: "SalesUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesUser",
                table: "SalesUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_SalesUser_SalesUserId",
                table: "Appointments",
                column: "SalesUserId",
                principalTable: "SalesUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "SalesUsers",
                newName: "SalesUser");
        }
    }
}
