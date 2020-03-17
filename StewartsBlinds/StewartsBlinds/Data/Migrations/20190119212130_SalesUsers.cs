using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StewartsBlinds.Data.Migrations
{
    public partial class SalesUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesUser", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "SalesUserId",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SalesUserId",
                table: "Appointments",
                column: "SalesUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_SalesUser_SalesUserId",
                table: "Appointments",
                column: "SalesUserId",
                principalTable: "SalesUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_SalesUser_SalesUserId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_SalesUserId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "SalesUserId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "SalesUser");
        }
    }
}
