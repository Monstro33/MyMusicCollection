//using MyMusicCollection.Models;
//using MyMusicCollection.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using Xunit;

//namespace MyMusicCollection.Tests
//{
//    public class SongRepositoryTests
//    {
//        [Fact]
//        public void Count_Starts_At_Zero()
//        {
//            var db = new MusicContext();
//            var underTest = new SongRepository(db);

//            var count = underTest.Count();

//            Assert.Equal(0, count);
//        }

//        [Fact]
//        public void Create_Increases_Count()
//        {
//            var db = new MusicContext();
//            var underTest = new SongRepository(db);

//            underTest.Create(new Song() { Title = "Foo" });

//            var count = underTest.Count();
//            Assert.Equal(1, count);
//        }
//    }
//}
