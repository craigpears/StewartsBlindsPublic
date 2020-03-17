using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StewartsBlinds.Data.Migrations
{
    public partial class VerticalBlinds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brackets",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ControlSide",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ControlType",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fabric",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadrailType",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SizeType",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stacking",
                table: "QuoteLine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeightsChain",
                table: "QuoteLine",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brackets",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "ControlSide",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "ControlType",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Fabric",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "HeadrailType",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "SizeType",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "Stacking",
                table: "QuoteLine");

            migrationBuilder.DropColumn(
                name: "WeightsChain",
                table: "QuoteLine");
        }
    }
}
