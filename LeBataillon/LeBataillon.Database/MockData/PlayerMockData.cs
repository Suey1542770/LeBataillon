using System;
using System.Collections.Generic;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.MockData
{
    public class PlayerMockData
    {
        public static List<Player> GetPlayersTest()
        {
            var _Players = new List<Player>()

            {

                new Player()
                {
                    Id = 1,
                    NickName = "sam",
                    Email = "Sam@email.com",
                    PhoneNumber = "222 222 2222",
                    FirstName ="sam",
                    LastName = "son",
                    Level = PlayerLevel.avancé,
                    TeamId = 1,

                },
                new Player()
                {
                    Id = 2,
                    NickName = "john",
                    Email = "john@email.com",
                    PhoneNumber = "222 222 2222",
                    FirstName ="jonny",
                    LastName = "go",
                    Level = PlayerLevel.avancé,
                    TeamId = 1,

                },
                new Player()
                {
                    Id = 3,
                    NickName = "tom",
                    Email = "tom@email.com",
                    PhoneNumber = "222 222 2222",
                    FirstName ="tom",
                    LastName = "ni",
                    Level = PlayerLevel.avancé,
                    TeamId = 1,

                },
                new Player()
                {
                    Id = 4,
                    NickName = "laura",
                    Email = "laura@email.com",
                    PhoneNumber = "222 222 2222",
                    FirstName ="laura",
                    LastName = "go",
                    Level = PlayerLevel.avancé,
                    TeamId = 1,

                },
                new Player()
                {
                    Id = 5,
                    NickName = "nick",
                    Email = "nick@email.com",
                    PhoneNumber = "222 222 2222",
                    FirstName ="nick",
                    LastName = "rom",
                    Level = PlayerLevel.avancé,
                    TeamId = 1,

                },
                new Player()
                {
                    Id = 6,
                    NickName = "sarah",
                    Email = "sarah@email.com",
                    PhoneNumber = "222 222 2222",
                    FirstName ="sarah",
                    LastName = "san",
                    Level = PlayerLevel.avancé,
                    TeamId = 1,

                },
                new Player()
                {
                    Id = 7,
                    NickName = "jerry",
                    Email = "jerry@email.com",
                    PhoneNumber = "222 222 2222",
                    FirstName ="jerry",
                    LastName = "pi",
                    Level = PlayerLevel.avancé,
                    TeamId = 2,

                },
                new Player()
                {
                    Id = 8,
                    NickName = "simon",
                    Email = "simon@email.com",
                    PhoneNumber = "222 222 2222",
                    FirstName ="simon",
                    LastName = "con",
                    Level = PlayerLevel.avancé,
                    TeamId = 2,

                },
                new Player()
                {
                    Id = 9,
                    NickName = "onix",
                    Email = "onix@email.com",
                    PhoneNumber = "222 222 2222",
                    FirstName ="onix",
                    LastName = "roche",
                    Level = PlayerLevel.avancé,
                    TeamId = 2,

                },
                new Player()
                {
                    Id = 10,
                    NickName = "pik",
                    Email = "pik@email.com",
                    PhoneNumber = "222 222 2222",
                    FirstName ="pik",
                    LastName = "achu",
                    Level = PlayerLevel.avancé,
                    TeamId =2,

                },
                new Player()
                {
                    Id = 11,
                    NickName = "pid",
                    Email = "pid@email.com",
                    PhoneNumber = "222 222 2222",
                    FirstName ="pid",
                    LastName = "gyeotto",
                    Level = PlayerLevel.avancé,
                    TeamId = 2,

                },
                new Player()
                {
                    Id = 12,
                    NickName = "rat",
                    Email = "rat@email.com",
                    PhoneNumber = "222 222 2222",
                    FirstName ="rat",
                    LastName = "ata",
                    Level = PlayerLevel.avancé,
                    TeamId = 2,

                },
                 new Player()
                {
                    Id = 13,
                    NickName = "Niconi",
                    Email = "Nico@email.com",
                    PhoneNumber = "222 222 2222",
                    FirstName ="Nico",
                    LastName = "Yazawa",
                    Level = PlayerLevel.avancé,
                    TeamId = null,
                }

            };


            return _Players;
        }
    }
}
