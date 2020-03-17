using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StewartsBlinds.Data.Migrations
{
    public partial class PaymentsAndQuoteLines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppointmentId = table.Column<int>(nullable: false),
                    PaymentMethod = table.Column<int>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    TakenBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddColumn<string>(
                name: "BeadDepth",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Braid",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Control",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Controls",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Draw",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Endcaps",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Finial",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FittingBrackets",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hardware",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HoldDownBrackets",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HooksRequired",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lining",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSlats",
                table: "QuoteLine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PoleColour",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PoleSize",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductType",
                table: "QuoteLine",
                nullable: false,
                defaultValue: ProductType.Vertical);

            migrationBuilder.AddColumn<string>(
                name: "Profile",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RingsRequired",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SampleRetained",
                table: "QuoteLine",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Scallop",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SlatColour",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SlatSize",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slatting",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "System",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tape",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrackColour",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrackWidth",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TracksRequired",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnderGuarantee",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WindowSizeRef",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WindowType",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_AppointmentId",
                table: "Payment",
                column: "AppointmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeadDepth",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Braid",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Control",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Controls",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Draw",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Endcaps",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Finial",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "FittingBrackets",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Hardware",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "HoldDownBrackets",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "HooksRequired",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Lining",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "NumberOfSlats",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "PoleColour",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "PoleSize",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Profile",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "RingsRequired",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "SampleRetained",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Scallop",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "SlatColour",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "SlatSize",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Slatting",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "System",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Tape",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "TrackColour",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "TrackWidth",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "TracksRequired",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "UnderGuarantee",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "WindowSizeRef",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "WindowType",
                table: "QuoteLine");

            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
