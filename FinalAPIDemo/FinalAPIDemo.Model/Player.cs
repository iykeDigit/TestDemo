using System.ComponentModel.DataAnnotations;

namespace FinalAPIDemo.Model
{
    public class Player
    {
        [Key]
        public string? PlayerID { get; set; }
        public int? BirthYear { get; set; } 
        public int? BirthMonth { get; set; }
        public int? BirthDay { get; set; }
        public string BirthCountry { get; set; } = string.Empty;
        public string? BirthState { get; set; } = string.Empty;
        public string? BirthCity { get; set; } = string.Empty;
        public int? DeathYear { get; set; }
        public int? DeathMonth { get; set; }
        public int? DeathDay { get; set; }
        public string? DeathCountry { get; set; } = string.Empty;
        public string? DeathState { get; set; } = string.Empty;
        public string? DeathCity { get; set; } = string.Empty;
        public string? NameFirst { get; set; } = string.Empty;
        public string? NameLast { get; set; } = string.Empty;
        public string? NameGiven { get; set; } = string.Empty;
        public int? Weight { get; set; } = 0;
        public int? Height { get; set; } = 0;
        public string? Bats { get; set; } = string.Empty;
        public string? Throws { get; set; } = string.Empty;
        public DateTime? Debut { get; set; } 
        public DateTime? FinalGame { get; set; }
        public string? RetroID { get; set; } = string.Empty;
        public string? BbrefID { get; set; } = string.Empty;
    }

}
