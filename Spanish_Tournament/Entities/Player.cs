namespace Spanish_Tournament.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Number { get; set; }
        public DateTime Birthdate { get; set; }
        public int TeamId { get; set; }
        public int PositionId { get; set; }

        public Team? Team { get; set; }
        public Position? Position { get; set; }
        public ICollection<Goal>? Goals { get; set; }
    }
}

