﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyMusicCollection;

namespace MyMusicCollection.Migrations
{
    [DbContext(typeof(MusicContext))]
    [Migration("20190321010020_FixImages2")]
    partial class FixImages2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyMusicCollection.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumImageLocation");

                    b.Property<string>("AlbumInfo");

                    b.Property<string>("AlbumName");

                    b.Property<string>("AlbumReviewContent");

                    b.HasKey("Id");

                    b.ToTable("Albums");

                    b.HasData(
                        new { Id = 1, AlbumImageLocation = "/Img/RapCover.jpg", AlbumInfo = " This collection of some of Rap Music's greatest old school hits. If your looking for a classic hip-hop education or just want to rewind your mind to a place called 'Back In The Day', this album is perfect for you.", AlbumName = "Old School", AlbumReviewContent = "These jams take me on a trip to when life was easy. Back in the day rap really is better than all this new garbage.Lewis --- Memphis" },
                        new { Id = 2, AlbumImageLocation = "/Img/ReggaeCover.jpg", AlbumInfo = "Sooth your mind, body, and soul in this collection of current Reggae hits.", AlbumName = "Relax", AlbumReviewContent = "I work this crazy job but this playlist really gets my mind in the right place. A definate home run for dealing with stress.Teddy --- Tampa" },
                        new { Id = 3, AlbumImageLocation = "/Img/AlternativeCover.jpg", AlbumInfo = "A collection of early Alternative tracks that caused a big splash on the Alternative Music charts.", AlbumName = "Waves", AlbumReviewContent = "This is my goto playlist. D.J. Mic you did it again. I cant wait for more like this.Teddy --- Tampa" }
                    );
                });

            modelBuilder.Entity("MyMusicCollection.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("SongImageLocation");

                    b.Property<string>("SongInfo");

                    b.Property<string>("SongName");

                    b.Property<string>("SongReviewContent");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new { Id = 1, AlbumId = 1, SongImageLocation = "/Img/Juicy.jpg", SongInfo = "This song  by rapper Notorious BIG, is a 'rags to riches chronicle' detailing his childhood years in poverty, his initial dreams of becoming a rapper and his early musical influences, his time dealing drugs and being involved in crime, and his eventual success in the music business and current lavish lifestyle.", SongName = "Juicy", SongReviewContent = "This is the song that put Gangsta Rap on the map. When are we gonna get another Notorious BIG worthy rapper?Bill --- Los Angeles" },
                        new { Id = 2, AlbumId = 1, SongImageLocation = "/Img/DearMama.jpg", SongInfo = "This song by rapper 2Pac is a tribute to his mother, Afeni Shakur. In the song, Shakur details his childhood poverty and his mother's addiction to crack cocaine, but argues that his love and deep respect for his mother supersede bad memories.", SongName = "Dear Mama", SongReviewContent = "Why did 2Pac have to leave us, he was so talented. Listening to this song makes me want to be a better son, which is a good thing. Thank you for everything Mom.Iba --- Richmond" },
                        new { Id = 3, AlbumId = 1, SongImageLocation = "/Img/Crossroads.jpg", SongInfo = "This song, written by the rap group Bone Thugs-n-Harmony, is dedicated to the group's mentor, the late Rap icon Easy-E, and other family members.", SongName = "Cross Roads", SongReviewContent = "This has to be the all time greatest rap song ever. Bone-Thugs-n-Harmony will never get old.Oscar --- Chicago" },
                        new { Id = 4, AlbumId = 2, SongImageLocation = "/Img/YouAndMe.jpg", SongInfo = "The song, written by reggae group SOJA (Soldiers Of Jah Army), is about love that never quits through any situation.", SongName = "You and Me", SongReviewContent = "I played this song at my wedding and it almost made me cry, the good tears. This song is deep man.Ignacio --- El Paso" },
                        new { Id = 5, AlbumId = 2, SongImageLocation = "/Img/Aroma.jpg", SongInfo = "The song, written by reggae group Tribal Seeds, sets the listener into the right vibe to feel musically uplifted. The addition of dub effects toward the end of the song are so catchy and well-chosen. this song is a perfect welcome to any party.", SongName = "Aroma", SongReviewContent = "This song  has such a catchy tune and the lyrics really do uplift your mind. I love it ---Joe Phoenix" },
                        new { Id = 6, AlbumId = 2, SongImageLocation = "/Img/GoodVibes.jpg", SongInfo = "this song, written by the Reggae group Rebelution, is a statement against racism and discrimination. Rebelution calls for an end of ignorance and calls for learning about different cultures rather than simply judging based on appearance.", SongName = "Good Vibes", SongReviewContent = "What can I saw about how this song makes me feel that the song title didnt already say.  Great playlist song.Bob --- San Diego" },
                        new { Id = 7, AlbumId = 3, SongImageLocation = "/Img/Everlong.jpg", SongInfo = "This song by Foo Fighters was written against the background of the break-up of Dave Grohl's first marriage to photographer Jennifer Youngblood and then falling for Louise Post of the band Veruca Salt. The song is about a girl that he had fallen in love with and it was basically about being connected to someone so much, that not only do you love them physically and spiritually, but when you sing along with them you harmonize perfectly.", SongName = "Everlong", SongReviewContent = "This song rocks. I could listen to it on repeat all day.Mike --- Houstan" },
                        new { Id = 8, AlbumId = 3, SongImageLocation = "/Img/1979.jpg", SongInfo = "A collection of early Alternative tracks that caused a big splash on the Alternative Music charts.", SongName = "1979", SongReviewContent = "This song rocks. I could listen to it on repeat all day.John --- Seattle" },
                        new { Id = 9, AlbumId = 3, SongImageLocation = "/Img/Comedown.jpg", SongInfo = "A collection of early Alternative tracks that caused a big splash on the Alternative Music charts.", SongName = "Comedown", SongReviewContent = "I feel like I can never come down when I listen to this track. Definately one of my top 10.Rick --- D.C." }
                    );
                });

            modelBuilder.Entity("MyMusicCollection.Models.Song", b =>
                {
                    b.HasOne("MyMusicCollection.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
