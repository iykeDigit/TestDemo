using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalAPIDemo.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BirthYear = table.Column<int>(type: "int", nullable: true),
                    BirthMonth = table.Column<int>(type: "int", nullable: true),
                    BirthDay = table.Column<int>(type: "int", nullable: true),
                    BirthCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeathYear = table.Column<int>(type: "int", nullable: true),
                    DeathMonth = table.Column<int>(type: "int", nullable: true),
                    DeathDay = table.Column<int>(type: "int", nullable: true),
                    DeathCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeathState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeathCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameFirst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameLast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameGiven = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true),
                    Bats = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Throws = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinalGame = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RetroID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BbrefID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
