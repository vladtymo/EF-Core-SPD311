namespace Spanish_Tournament.Entities
{
    public class Goal
    {
        public int Id { get; set; }
        public int Minute { get; set; }
        public int MatchId { get; set; }
        public int PlayerId { get; set; }
        public int TeamId { get; set; }

        public Match? Match { get; set; }
        public Team? Team { get; set; }
        public Player? Player { get; set; }
    }
}

