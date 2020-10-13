
using Xunit;

using LeBataillon.Database.Models;
namespace LeBataillon.Test
{

    public class Player_Tests
    {

        [Fact]
        public void Edit_test()
        {
            //Arrange
            Player player = new Player
            {
                Id = 1,
                NickName = "Nico",
                Email = "Nico23@Email.com",
                PhoneNumber = "450-999-9999",
                FirstName = "Nicolas",
                LastName = "Salon",
                Level = PlayerLevel.débutant,
            };
            Player player1 = new Player
            {
                Id = 1,
                NickName = "Math",
                Email = "Math@Email.com",
                PhoneNumber = "450-999-9999",
                FirstName = "Mathieu",
                LastName = "Salon",
                Level = PlayerLevel.débutant,
            };
            //Act
            player.EditFrom(player1);
            //Assert
            Assert.True(player.Email == player1.Email);
            Assert.True(player.NickName == player1.NickName);
            Assert.True(player.Id == player1.Id);
            Assert.True(player.FirstName == player1.FirstName);
            Assert.True(player.LastName == player1.LastName);
            Assert.True(player.PhoneNumber == player1.PhoneNumber);
            Assert.True(player.TeamId == player1.TeamId);
            Assert.True(player.Level == player1.Level);
        }

    }
}