using System;
using System.Collections.Generic;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.MockData
{
    public class GameMockData
    {
        public static List<Game> GetGamesTest()
        {
            var _Games = new List<Game>()

            {

                new Game()
                {
                    Id = 1,
                    TeamAttackerId = 1,
                    TeamDefendantId = 2,
                    GameDateTime = DateTime.Now,

                },

            };
            return _Games;
        }
    }
}
