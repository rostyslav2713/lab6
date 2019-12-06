using System.ComponentModel.DataAnnotations;

namespace lab6.Models
{
    public class Match
    {
        [Key]
        public int matchId { get; set; }
        public string matchFirstTeam { get; set; }
        public string matchSecondTeam { get; set; }
        public int matchTicketPrice { get; set; }

    }
}