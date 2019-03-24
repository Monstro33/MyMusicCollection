using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMusicCollection.Migrations
{
    public partial class updatePhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumName = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbumImageLocation = table.Column<string>(nullable: true),
                    AlbumInfo = table.Column<string>(nullable: true),
                    AlbumReviewContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SongName = table.Column<string>(nullable: true),
                    SongImageLocation = table.Column<string>(nullable: true),
                    SongInfo = table.Column<string>(nullable: true),
                    AlbumId = table.Column<int>(nullable: false),
                    SongReviewContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumImageLocation", "AlbumInfo", "AlbumName", "AlbumReviewContent" },
                values: new object[] { 1, "/Img/RapCover.jpg", " This collection of some of Rap Music's greatest old school hits. If your looking for a classic hip-hop education or just want to rewind your mind to a place called 'Back In The Day', this album is perfect for you.", "Old School", "These jams take me on a trip to when life was easy. Back in the day rap really is better than all this new garbage.Lewis --- Memphis" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumImageLocation", "AlbumInfo", "AlbumName", "AlbumReviewContent" },
                values: new object[] { 2, "/Img/ReggaeCover.jpg", "Sooth your mind, body, and soul in this collection of current Reggae hits.", "Relax", "I work this crazy job but this playlist really gets my mind in the right place. A definate home run for dealing with stress.Teddy --- Tampa" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumImageLocation", "AlbumInfo", "AlbumName", "AlbumReviewContent" },
                values: new object[] { 3, "/Img/AlternativeCover.jpg", "A collection of early Alternative tracks that caused a big splash on the Alternative Music charts.", "Waves", "This is my goto playlist. D.J. Mic you did it again. I cant wait for more like this.Teddy --- Tampa" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "SongImageLocation", "SongInfo", "SongName", "SongReviewContent" },
                values: new object[,]
                {
                    { 1, 1, "/Img/Juicy.jpg", "This song  by rapper Notorious BIG, is a 'rags to riches chronicle' detailing his childhood years in poverty, his initial dreams of becoming a rapper and his early musical influences, his time dealing drugs and being involved in crime, and his eventual success in the music business and current lavish lifestyle.", "Juicy", "This is the song that put Gangsta Rap on the map. When are we gonna get another Notorious BIG worthy rapper?Bill --- Los Angeles" },
                    { 2, 1, "/Img/DearMama.jpg", "This song by rapper 2Pac is a tribute to his mother, Afeni Shakur. In the song, Shakur details his childhood poverty and his mother's addiction to crack cocaine, but argues that his love and deep respect for his mother supersede bad memories.", "Dear Mama", "Why did 2Pac have to leave us, he was so talented. Listening to this song makes me want to be a better son, which is a good thing. Thank you for everything Mom.Iba --- Richmond" },
                    { 3, 1, "/Img/Crossroads.jpg", "This song, written by the rap group Bone Thugs-n-Harmony, is dedicated to the group's mentor, the late Rap icon Easy-E, and other family members.", "Cross Roads", "This has to be the all time greatest rap song ever. Bone-Thugs-n-Harmony will never get old.Oscar --- Chicago" },
                    { 4, 2, "/Img/YouAndMe.jpg", "The song, written by reggae group SOJA (Soldiers Of Jah Army), is about love that never quits through any situation.", "You and Me", "I played this song at my wedding and it almost made me cry, the good tears. This song is deep man.Ignacio --- El Paso" },
                    { 5, 2, "/Img/Aroma.jpg", "The song, written by reggae group Tribal Seeds, sets the listener into the right vibe to feel musically uplifted. The addition of dub effects toward the end of the song are so catchy and well-chosen. this song is a perfect welcome to any party.", "Aroma", "This song  has such a catchy tune and the lyrics really do uplift your mind. I love it ---Joe Phoenix" },
                    { 6, 2, "/Img/GoodVibes.jpg", "this song, written by the Reggae group Rebelution, is a statement against racism and discrimination. Rebelution calls for an end of ignorance and calls for learning about different cultures rather than simply judging based on appearance.", "Good Vibes", "What can I saw about how this song makes me feel that the song title didnt already say.  Great playlist song.Bob --- San Diego" },
                    { 7, 3, "/Img/Everlong.jpg", "This song by Foo Fighters was written against the background of the break-up of Dave Grohl's first marriage to photographer Jennifer Youngblood and then falling for Louise Post of the band Veruca Salt. The song is about a girl that he had fallen in love with and it was basically about being connected to someone so much, that not only do you love them physically and spiritually, but when you sing along with them you harmonize perfectly.", "Everlong", "This song rocks. I could listen to it on repeat all day.Mike --- Houstan" },
                    { 8, 3, "/Img/1979.jpg", "A collection of early Alternative tracks that caused a big splash on the Alternative Music charts.", "1979", "This song rocks. I could listen to it on repeat all day.John --- Seattle" },
                    { 9, 3, "/Img/Comedown.jpg", "A collection of early Alternative tracks that caused a big splash on the Alternative Music charts.", "Comedown", "I feel like I can never come down when I listen to this track. Definately one of my top 10.Rick --- D.C." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
