namespace Spanish_Tournament.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Player>? Players { get; set; }
    }
}

