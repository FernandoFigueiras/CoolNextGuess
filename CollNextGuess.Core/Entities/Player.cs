namespace CollNextGuess.Core.Entities
{
    public class Player : IEntity
    {
        public Player(string name, int turn, int points)
        {
            Name = name;
            Turn = turn;
            Points = points;
            IsActive = turn == 1;
        }

        public int Id { get; set; }

        public string? Name { get; set; }

        public int Turn { get; set; }

        public int Points { get; set; }

        public bool IsActive { get; set; }

        public int GetGameRank() => Points;

        public string GetPLayerName() => Name is null ? $"Player_{Turn}" : Name;
    }
}
