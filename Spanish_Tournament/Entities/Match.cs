namespace Spanish_Tournament.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int HomeTeamId { get; set; }
        public int GuestTeamId { get; set; }

        public Team? HomeTeam { get; set; }
        public Team? GuestTeam { get; set; }
        public ICollection<Goal>? Goals { get; set; }
    }
}

