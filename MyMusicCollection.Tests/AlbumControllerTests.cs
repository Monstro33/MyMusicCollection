using System;
using Xunit;
using MyMusicCollection.Controllers;
using MyMusicCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyMusicCollection.Models;
using NSubstitute;

namespace MyMusicCollection.Tests
{
    public class AlbumControllerTests
    {
        AlbumController underTest;
        private IAlbumRepository repo;

        public AlbumControllerTests()
        {
            repo = Substitute.For<IAlbumRepository>();
            underTest = new AlbumController(repo);
        }

        [Fact]
        public void Index_Returns_A_View_Result()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Has_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Sets_Model_To_All_Albums()
        {
            var expectedModel = new List<Album>();
            repo.GetAll().Returns(expectedModel);

            var result = underTest.Index();
            var model = (IEnumerable<Album>)result.Model;
            Assert.Equal(expectedModel, model);
        }

        [Fact]
        public void Details_Model_Is_Expected_Model()
        {
            var expectedId = 1;
            var expectedModel = new Album();
            //                repo.GetByID(expectedId).Returns(expectedModel);

            var result = underTest.Details(expectedId);
            var model = (Album)result.Model;

            Assert.Equal(expectedModel, model);
        }

        [Fact]
        public void Can_Create_Album()
        {
            var movieRepo = new AlbumRepository(null);
            var underTest = new AlbumController(movieRepo);

            var result = underTest.Create();

            Assert.IsType<ViewResult>(result);

        }
    }
}

