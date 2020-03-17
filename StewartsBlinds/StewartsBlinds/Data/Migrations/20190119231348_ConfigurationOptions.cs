using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StewartsBlinds.Data.Migrations
{
    public partial class ConfigurationOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuoteLine_Appointments_AppointmentId",
                table: "QuoteLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuoteLine",
                table: "QuoteLine");

            migrationBuilder.CreateTable(
                name: "ConfigurationOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FieldName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProductType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationOptions", x => x.Id);
                });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuoteLines",
                table: "QuoteLine",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuoteLines_Appointments_AppointmentId",
                table: "QuoteLine",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameIndex(
                name: "IX_QuoteLine_AppointmentId",
                table: "QuoteLine",
                newName: "IX_QuoteLines_AppointmentId");

            migrationBuilder.RenameTable(
                name: "QuoteLine",
                newName: "QuoteLines");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuoteLines_Appointments_AppointmentId",
                table: "QuoteLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuoteLines",
                table: "QuoteLines");

            migrationBuilder.DropTable(
                name: "ConfigurationOptions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuoteLine",
                table: "QuoteLines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuoteLine_Appointments_AppointmentId",
                table: "QuoteLines",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameIndex(
                name: "IX_QuoteLines_AppointmentId",
                table: "QuoteLines",
                newName: "IX_QuoteLine_AppointmentId");

            migrationBuilder.RenameTable(
                name: "QuoteLines",
                newName: "QuoteLine");
        }
    }
}
