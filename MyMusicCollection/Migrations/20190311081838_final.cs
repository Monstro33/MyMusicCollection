using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMusicCollection.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumIdImage",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "AlbumIdInfo",
                table: "Songs",
                newName: "SongReviewContent");

            migrationBuilder.AddColumn<string>(
                name: "AlbumReviewContent",
                table: "Albums",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "AlbumReviewContent",
                value: "These jams take me on a trip to when life was easy. Back in the day rap really is better than all this new garbage.Lewis --- Memphis");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "AlbumReviewContent",
                value: "I work this crazy job but this playlist really gets my mind in the right place. A definate home run for dealing with stress.Teddy --- Tampa");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                column: "AlbumReviewContent",
                value: "This is my goto playlist. D.J. Mic you did it again. I cant wait for more like this.Teddy --- Tampa");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "SongReviewContent",
                value: "This is the song that put Gangsta Rap on the map. When are we gonna get another Notorious BIG worthy rapper?Bill --- Los Angeles");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "SongReviewContent",
                value: "Why did 2Pac have to leave us, he was so talented. Listening to this song makes me want to be a better son, which is a good thing. Thank you for everything Mom.Iba --- Richmond");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "SongReviewContent",
                value: "This has to be the all time greatest rap song ever. Bone-Thugs-n-Harmony will never get old.Oscar --- Chicago");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "SongReviewContent",
                value: "I played this song at my wedding and it almost made me cry, the good tears. This song is deep man.Ignacio --- El Paso");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                column: "SongReviewContent",
                value: "This song  has such a catchy tune and the lyrics really do uplift your mind. I love it ---Joe Phoenix");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                column: "SongReviewContent",
                value: "What can I saw about how this song makes me feel that the song title didnt already say.  Great playlist song.Bob --- San Diego");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7,
                column: "SongReviewContent",
                value: "This song rocks. I could listen to it on repeat all day.Mike --- Houstan");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8,
                column: "SongReviewContent",
                value: "This song rocks. I could listen to it on repeat all day.John --- Seattle");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9,
                column: "SongReviewContent",
                value: "I feel like I can never come down when I listen to this track. Definately one of my top 10.Rick --- D.C.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumReviewContent",
                table: "Albums");

            migrationBuilder.RenameColumn(
                name: "SongReviewContent",
                table: "Songs",
                newName: "AlbumIdInfo");

            migrationBuilder.AddColumn<string>(
                name: "AlbumIdImage",
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
                columns: new[] { "AlbumIdImage", "AlbumIdInfo" },
                values: new object[] { "Img/AlternativeCover.jpeg", "A collection of early Alternative tracks that caused a big splash on the Alternative Music charts." });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AlbumIdImage", "AlbumIdInfo" },
                values: new object[] { "Img/AlternativeCover.jpeg", "A collection of early Alternative tracks that caused a big splash on the Alternative Music charts." });
        }
    }
}
