using System;
using System.Data.SqlTypes;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieU.Data.Migrations
{
    public partial class Movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TvShows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Photo = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    StreamUrl = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Episode = table.Column<int>(type: "INTEGER", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShows", x => x.Id);
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TvShows");
        }
    }
}
