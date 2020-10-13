using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace LeBataillon.Database.Models
{
    public class Team
    {
        public Team()
        {


        }

        public Team(int i, string teamName)
        {


        }

        public Team(int Id, string TeamName, int? Captain)
        {
            this.Id = Id;
            this.TeamName = TeamName;
            this.CaptainId = Captain;

        }

        public void EditFrom(Team t)
        {
            this.Id = t.Id;
            this.TeamName = t.TeamName;
            this.CaptainId = t.CaptainId;
            this.Players = t.Players;

        }
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string TeamName { get; set; }


        public int? CaptainId { get; set; }
        [ForeignKey("CaptainId")]
        public virtual Player Captain { get; set; }

        [InverseProperty("team")]

        public virtual List<Player> Players { get; set; }



    }
}