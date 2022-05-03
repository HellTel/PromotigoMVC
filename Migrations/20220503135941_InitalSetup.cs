using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PromotigoMVC.Migrations
{
    public partial class InitalSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrant",
                columns: table => new
                {
                    EntrantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntrantFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntrantSurname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrant", x => x.EntrantID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entrant");
        }
    }
}
