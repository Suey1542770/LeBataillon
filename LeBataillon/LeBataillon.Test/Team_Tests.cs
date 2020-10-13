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
    public class Team_Tests
    {
        [Fact]
        public void Captain_Test()
        {
            //arrange
            List<Player> players = PlayerMockData.GetPlayersTest();
            List<Team> teams = TeamMockData.GetTeamsTest();
            Team team = teams[0];
            var nat = 3;






        }
    }
}
