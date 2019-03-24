//using MyMusicCollection.Controllers;
//using MyMusicCollection.Repositories;
//using System.Collections.Generic;
//using Xunit;
//using MyMusicCollection.Models;
//using Microsoft.AspNetCore.Mvc;
//using NSubstitute;

//namespace MyMusicCollection.Tests
//{
//    public class SongControllerTests
//    {
//        SongController sut;
//        private ISongRepository repo;

//        public SongControllerTests()
//        {
//            repo = Substitute.For<ISongRepository>();
//            sut = new SongController(repo);
//        }

//        [Fact]
//        public void Index_Returns_View_Result()
//        {
//            var result = sut.Index();

//            Assert.IsType<ViewResult>(result);
//        }

//        [Fact]
//        public void Index_Model_Is_Expected_Model()
//        {
//            var expectedModel = new List<Song>();
//            repo.GetAll().Returns(expectedModel);

//            var result = sut.Index();
//            var model = (IEnumerable<Song>)result.Model;

//            Assert.Equal(expectedModel, model);
//        }

//        [Fact]
//        public void Details_Model_Is_Expected_Model()
//        {
//            var expectedId = 2;
//            var expectedModel = new Song();

//            repo.GetById(expectedId).Returns(expectedModel);

//            var result = sut.Details(expectedId);
//            var model = (Song)result.Model;
//            Assert.Equal(expectedModel, model);
//        }

//        [Fact]
//        public void Boat_Is_Added()
//        {

//        }
//    }
//}



