namespace Spanish_Tournament.Entities
{
    public class Goal
    {
        public int Id { get; set; }
        public int Minute { get; set; }
        public int? HomeMatchId { get; set; }
        public int? GuestMatchId { get; set; }
        public int PlayerId { get; set; }

        public Match? HomeMatch { get; set; }
        public Match? GuestMatch { get; set; }
        public Player? Player { get; set; }
    }
}

