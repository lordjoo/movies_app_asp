using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieU.Data.Migrations
{
    public partial class PopulateTvShows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.InsertData(
            //     table: "TvShows",
            //     columns: new[] {"Name", "Photo", "Episode", "StreamUrl","Tags"},
            //     values: new object[,]
            //     {
            //         {"The Flash", "https://i.ibb.co/Y0xjvPW/5f6c62cfc5167.jpg", 1, "https://vidhd.org/embed-gc1kthk5nsmt.html","Tag"}, 
            //         {"The Flash", "https://i.ibb.co/Y0xjvPW/5f6c62cfc5167.jpg", 2, "https://vidhd.org/embed-6jm6ixttkbtc.html","Tag"},
            //         {"The Flash", "https://i.ibb.co/Y0xjvPW/5f6c62cfc5167.jpg", 3, "https://vidhd.org/embed-45156enomefa.html","Tag"},
            //         
            //         {"Agents of S.H.I.E.L.D", "https://i.ibb.co/zRhDW16/5f42f822dff4a.jpg", 1, "https://vidhd.org/embed-2pakoghiur6d.html","Tag"},
            //         {"Agents of S.H.I.E.L.D", "https://i.ibb.co/zRhDW16/5f42f822dff4a.jpg", 1, "https://vidhd.org/embed-efkgeif76hw2.html","Tag"},
            //         
            //         {"The BlackList", "https://i.ibb.co/j56RGfY/tt2741602.jpg", 12, "https://vidhd.org/embed-ixnzo1zshf8k.html","Tag"},
            //         
            //         
            //     }
            // );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
