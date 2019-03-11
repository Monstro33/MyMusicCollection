using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMusicCollection.Migrations
{
    public partial class UpdateSeedData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlbumIdImage",
                table: "Songs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlbumIdInfo",
                table: "Songs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AlbumIdImage", "AlbumIdInfo" },
                values: new object[] { "Img/RapCover.jpeg", "This collection of some of Rap Music's greatest old school hits. If your looking for a classic hip-hop education or just want to rewind your mind to a place called 'Back In The Day', this album is perfect for you." });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AlbumIdImage", "AlbumIdInfo" },
                values: new object[] { "Img/RapCover.jpeg", "This collection of some of Rap Music's greatest old school hits. If your looking for a classic hip-hop education or just want to rewind your mind to a place called 'Back In The Day', this album is perfect for you." });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AlbumIdImage", "AlbumIdInfo" },
                values: new object[] { "Img/RapCover.jpeg", "This collection of some of Rap Music's greatest old school hits. If your looking for a classic hip-hop education or just want to rewind your mind to a place called 'Back In The Day', this album is perfect for you." });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AlbumIdImage", "AlbumIdInfo" },
                values: new object[] { "Img/ReggaeCover.jpeg", "Sooth your mind, body, and soul in this collection of current Reggae hits." });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AlbumIdImage", "AlbumIdInfo" },
                values: new object[] { "Img/ReggaeCover.jpeg", "Sooth your mind, body, and soul in this collection of current Reggae hits." });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AlbumIdImage", "AlbumIdInfo" },
                values: new object[] { "Img/ReggaeCover.jpeg", "Sooth your mind, body, and soul in this collection of current Reggae hits." });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AlbumIdImage", "AlbumIdInfo" },
                values: new object[] { "Img/AlternativeCover.jpeg", "A collection of early Alternative tracks that caused a big splash on the Alternative Music charts." });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AlbumIdImage", "AlbumIdInfo", "SongInfo" },
                values: new object[] { "Img/AlternativeCover.jpeg", "A collection of early Alternative tracks that caused a big splash on the Alternative Music charts.", "A collection of early Alternative tracks that caused a big splash on the Alternative Music charts." });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AlbumIdImage", "AlbumIdInfo", "SongInfo" },
                values: new object[] { "Img/AlternativeCover.jpeg", "A collection of early Alternative tracks that caused a big splash on the Alternative Music charts.", "A collection of early Alternative tracks that caused a big splash on the Alternative Music charts." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumIdImage",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "AlbumIdInfo",
                table: "Songs");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8,
                column: "SongInfo",
                value: "This song, by the Smashing Pumpkins frontman Billy Corgan, was written as a nostalgic coming of age story by Corgan. In the year 1979, Corgan was 12 and this is what he considered his transition into adolescence.");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9,
                column: "SongInfo",
                value: "This song by the British band Bush, was written about an ex-girlfriend, in the context of half regret, half celebration and just being objective about the situation of coming down from that high and dealing with those intense emotions. The idea of euphoria is amazing but having that euphoria has a comedown.");
        }
    }
}
