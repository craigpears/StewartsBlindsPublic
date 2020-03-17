using Microsoft.EntityFrameworkCore.Migrations;

namespace StewartsBlinds.Data.Migrations
{
    public partial class CustomerType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {  
            migrationBuilder.AddColumn<int>(
                name: "CustomerType",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerType",
                table: "Appointments");
        }
    }
}
