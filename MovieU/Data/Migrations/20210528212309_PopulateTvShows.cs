using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieU.Data.Migrations
{
    public partial class PopulateTvShows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TvShows",
                columns: new[] { "Name","Photo","StreamUrl" +
                                                "","Episode"},
                values: new object[] { "TheFlash","p/the_flash.jpg","Https://ok.ru",1 }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
