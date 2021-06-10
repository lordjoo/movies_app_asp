using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieU.Data.Migrations
{
    public partial class InsertMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] {"Name", "Photo", "StreamUrl"},
                values: new object[,]
                {
                    {"Dragon Rider", "https://i.ibb.co/2yp9wMG/bcc1c851-11d7-4217-9563-ef12db07f5c0.jpg", "https://vidhd.org/embed-6fxhyb0trsrb.html"},
                    {"Raya", "https://i.ibb.co/cL100SM/raya.jpg", "https://vedpom.com/embed-1f53shm8uzcb.html"},
                    {"Soul", "https://i.ibb.co/d4XXmjG/soul.jpg", "https://vedpom.com/embed-vj21xq0emn64.html"},
                    {"Monster pets", "https://i.ibb.co/7X7ShcR/Monster-Pets-Poster.jpg", "https://vedpom.com/embed-jfor90e3go3d.html"}
                }
            );
        }
            
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
