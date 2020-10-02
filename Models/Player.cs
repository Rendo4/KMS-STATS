namespace Stats.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Summoner { get; set; }
        public string Team { get; set; }
        public string Opponent { get; set; }
        public string Champion { get; set; }
        public string Role { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
    }
}