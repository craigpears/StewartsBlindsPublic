using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StewartsBlinds.Data.Migrations
{
    public partial class Appointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    AlternativeTelephone = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    DeliveryAddress1 = table.Column<string>(nullable: true),
                    DeliveryAddress2 = table.Column<string>(nullable: true),
                    DeliveryCounty = table.Column<string>(nullable: true),
                    DeliveryPostcode = table.Column<string>(nullable: true),
                    DeliveryTown = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FinalsiedDate = table.Column<DateTime>(nullable: false),
                    OrderPlaced = table.Column<bool>(nullable: true),
                    OrderSigned = table.Column<bool>(nullable: false),
                    Postcode = table.Column<string>(nullable: true),
                    PriceQuoted = table.Column<double>(nullable: false),
                    SameAsOrderAddress = table.Column<bool>(nullable: false),
                    SeenByFactory = table.Column<bool>(nullable: false),
                    SeenByOffice = table.Column<bool>(nullable: false),
                    SpecialInstructions = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    TermsAndConditionsLeft = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
