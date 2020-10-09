using Moq;
using System;
using Xunit;
using System.Linq;
using LeBataillon.Database.Repository;
using LeBataillon.Database.MockData;
using LeBataillon.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LeBataillon.Database.Models;
using LeBataillon.Database.Context;


namespace LeBataillon.Test
{
    public class PlayerController_Tests
    {

        [Fact]
        public void PlayerIndex_Test()
        {

            //arrange
            var mockRepo = new Mock<IPlayerRepo>();
            mockRepo.Setup(n => n.GetAll()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayersController(mockRepo.Object);

            //act
            var result = controller.Index();

            //assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PlayerIndexList_Test()
        {
            //arrange
            var mockRepo = new Mock<IPlayerRepo>();
            mockRepo.Setup(n => n.GetAll()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayersController(mockRepo.Object);

            //act
            var result = controller.Index();

            //assert
            var viewResult = result as ViewResult;
            Assert.IsAssignableFrom<List<Player>>(viewResult.ViewData.Model);
        }

        [Fact]
        public void PlayerIndexNombre_Test()

        {
            //arrange
            var mockRepo = new Mock<IPlayerRepo>();
            mockRepo.Setup(n => n.GetAll()).Returns(PlayerMockData.GetPlayersTest());
            var controller = new PlayersController(mockRepo.Object);

            //act
            var result = controller.Index();

            //assert
            var viewResult = result as ViewResult;
            var viewResultPlayers = viewResult.ViewData.Model as List<Player>;
            Assert.Equal(12, viewResultPlayers.Count);
        }
    }
}