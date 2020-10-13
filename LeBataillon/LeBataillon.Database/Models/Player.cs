using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeBataillon.Database.Models
{
    public class Player
    {
        public Player()
        {


        }

        public Player(int Id, string NickName, string Email, string PhoneNumber, string FirstName, string LastName, PlayerLevel level)
        {
            this.Id = Id;
            this.NickName = NickName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Level = Level;


        }

        public void EditFrom(Player p)
        {
            this.Id = p.Id;
            this.NickName = p.NickName;
            this.Email = p.Email;
            this.PhoneNumber = p.PhoneNumber;
            this.FirstName = p.FirstName;
            this.LastName = p.LastName;
            this.Level = p.Level;
            this.TeamId = p.TeamId;

        }
        [Required]
        public int Id { get; set; }
        [MaxLength(30)]
        public string NickName { get; set; }

        [Required(ErrorMessage = "Le courriel est requis")]
        [EmailAddress(ErrorMessage = "Le courriel n'est pas valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "le numero de téléphone est requis")]
        [Phone(ErrorMessage = "le numero de téléphone n'est pas valid")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Le prenom est requis")]
        [MaxLength(30, ErrorMessage = "Le prenom doit étre plus petit que 30 charactère")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Le nom est requis")]
        [MaxLength(30, ErrorMessage = "Le nom doit étre plus petit que 30 charactère")]
        public string LastName { get; set; }
        [Range(0, 3, ErrorMessage = "pas un choix valid")]
        public PlayerLevel Level { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "choisir un nombre entier positif")]
        public int? TeamId { get; set; }

        [ForeignKey("TeamId")]
        public virtual Team team { get; set; }



    }
}