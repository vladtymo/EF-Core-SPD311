namespace Spanish_Tournament.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CityId { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Draws { get; set; }

        public City? City { get; set; }
        public ICollection<Goal>? Goals { get; set; }
        public ICollection<Player>? Players { get; set; }
        public ICollection<Match>? HomeMatches { get; set; }
        public ICollection<Match>? GuestMatches { get; set; }
    }
}

