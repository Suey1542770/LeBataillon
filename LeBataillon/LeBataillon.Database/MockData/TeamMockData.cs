using System;
using System.Collections.Generic;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.MockData
{
    public class TeamMockData
    {
        public static List<Team> GetTeamsTest()
        {
            var _Teams = new List<Team>()

            {


                new Team{
                    Id = 1,
                    CaptainId = 1,
                    TeamName = "nice",
                },
                new Team{
                    Id = 7,
                    CaptainId = 2,
                    TeamName = "not nice",
                }

            };
            return _Teams;
        }
    }
}
