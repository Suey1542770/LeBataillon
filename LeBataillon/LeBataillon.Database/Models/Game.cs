using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LeBataillon.Database.Models
{
    public class Game
    {
        public Game()
        {


        }

        public Game(int Id, DateTime GameDateTime, int TeamDefendant, int TeamAttacker)
        {
            this.Id = Id;
            this.GameDateTime = GameDateTime;
            this.TeamDefendantId = TeamDefendant;
            this.TeamAttackerId = TeamAttacker;

        }

        public void EditFrom(Game g)
        {
            this.Id = g.Id;
            this.GameDateTime = g.GameDateTime;
            this.TeamDefendantId = g.TeamDefendantId;
            this.TeamAttackerId = g.TeamAttackerId;

        }
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime GameDateTime { get; set; }


        public int? TeamDefendantId { get; set; }
        public virtual Team TeamDefendant { get; set; }
        public int? TeamAttackerId { get; set; }
        public virtual Team TeamAttacker { get; set; }


    }
}