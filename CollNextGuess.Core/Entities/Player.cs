namespace CollNextGuess.Core.Entities
{
    public class Player : IEntity
    {
        public Player(string name, int turn, int points)
        {
            Name = name;
            Turn = turn;
            Points = points;
        }

        public int Id { get; set; }

        public string? Name { get; set; }

        public int Turn { get; set; } = 0;

        public int Points { get; private set; }

        public int GetGameRank() => Points;

        public string GetPLayerName() => Name is null ? $"Player_{Turn}" : Name;
    }
}
